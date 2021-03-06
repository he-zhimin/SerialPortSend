﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace SerialPortSend
{
    public partial class Form1 : Form
    {
        /// <summary>
        //默认为网络升级
        /// </summary>
        bool bUpdate = true;
        UdpClient udpClient;
        IPEndPoint locatePoint;

        IPAddress localIP = IPAddress.Parse("192.168.1.100");
        IPAddress remoteIP = null;
        IPEndPoint remotePoint = null;
        ///
        private delegate void displayResult(byte[] receive, int type);
        private displayResult disp_result;
        private string fileName;
        Queue<DataGridViewTextBoxCell> spList = new Queue<DataGridViewTextBoxCell>();
        private bool isContinue = true;
        private DataGridViewTextBoxCell curSP = null;
        public List<byte[]> fileData = new List<byte[]>();
        private int version = 0;
        private int type = 1;
        private int startPos = 1;
        private int curPos = 1;
        private List<byte> receiveBuf = new List<byte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string com in SerialPort.GetPortNames())
            {
                this.portNameCB.Items.Add(com);
            }
            this.baudRateCB.SelectedItem = "115200";
            this.dataBitCB.SelectedItem = "8";
            this.stopBitCB.SelectedItem = "1";
            this.parityCB.SelectedItem = "None";
            this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceivedEventHandler);
            this.disp_result = new displayResult(displayUI);
            this.spData.RowCount = 8;
            this.spData.ClearSelection();
            this.comboBox1.SelectedIndex = 0;
            remoteIP = IPAddress.Parse(this.ipTB.Text);

            ///////////////////////NetWork//////////////


            locatePoint = new IPEndPoint(localIP, Convert.ToInt32(this.portTB.Text));
            remotePoint = new IPEndPoint(remoteIP, Convert.ToInt32(this.portTB.Text));
            udpClient = new UdpClient(locatePoint);


            //监听创建好后，就开始接收信息，并创建一个线程
            Thread recThread = new Thread(Receive);
            recThread.IsBackground = true;
            recThread.Start();
        }

        void Receive()
        {
            byte[] rbuf;
            //远端IP
            IPEndPoint remotePoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {

                    rbuf = udpClient.Receive(ref remotePoint);
                    if (rbuf != null)
                    {
                        //string str = System.Text.Encoding.UTF8.GetString(recBuffer, 0, recBuffer.Length);

                        for (int i = 0; i < rbuf.Length; i++)
                        {
                            this.receiveBuf.Add(rbuf[i]);
                            if (this.receiveBuf.Count != 1 && this.receiveBuf[this.receiveBuf.Count - 1] == 0xc0)
                            {
                                byte[] buf = this.receiveBuf.ToArray();
                                int rtype = Message.checkReceiveData(buf);
                                this.Invoke(disp_result, buf, rtype);
                                if (rtype == 1)
                                {
                                    if (buf[1] == 0x01 || buf[2] == 0x00)
                                    {
                                        this.isContinue = false;
                                    }
                                    if (this.type == 2)
                                    {
                                        sendToSp6();
                                    }
                                    else
                                    {
                                        sendFileData();
                                    }
                                }
                                else if (rtype == 2)
                                {
                                    byte[] result = Message.getSP6SelfCheckMessage();
                                    udpClient.Send(result, result.Length, remotePoint);
                                }
                                this.receiveBuf.Clear();
                            }
                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

        }

        void SendData()
        {
            byte[] buffer = { 0x30, 0x31 };
            udpClient.Send(buffer, buffer.Length, remotePoint);

        }
        private void openBtn_Click(object sender, EventArgs e)
        {
            if (!this.serialPort1.IsOpen)
            {
                setSerialPortParam();
                if (string.IsNullOrEmpty(this.serialPort1.PortName))
                {
                    MessageBox.Show("未选择串口", "警告");
                    return;
                }
                try
                {

                    this.serialPort1.Open();
                    this.openBtn.Text = "关闭串口";
                }catch(Exception ex)
                {
                    MessageBox.Show("串口打开失败", "警告");
                }
                bUpdate = false;
            }
            else
            {
                this.serialPort1.Close();
                this.openBtn.Text = "打开串口";
            }
        }

        private void setSerialPortParam()
        {
            if (this.portNameCB.SelectedItem != null)
            {
                this.serialPort1.PortName = this.portNameCB.SelectedItem.ToString();
            }
            this.serialPort1.BaudRate = Int32.Parse(this.baudRateCB.SelectedItem.ToString());
            this.serialPort1.DataBits = Int32.Parse(this.dataBitCB.SelectedItem.ToString());
            if (this.dataBitCB.SelectedItem.ToString() == "1")
            {
                this.serialPort1.StopBits = StopBits.One;
            }else if(this.dataBitCB.SelectedItem.ToString() == "1.5")
            {
                this.serialPort1.StopBits = StopBits.OnePointFive;
            }else if(this.dataBitCB.SelectedItem.ToString() == "2")
            {
                this.serialPort1.StopBits = StopBits.Two;
            }
            this.serialPort1.Parity = (Parity)this.parityCB.SelectedIndex;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            getVersion();
            if (this.version == -1)
            {
                MessageBox.Show("请输入版本号", "警告");
            }
            getAllSelectSp6();
            this.isContinue = false;
            this.type = 2;
            sendToSp6();
        }

        private void sendFileData()
        {
            byte[] sendData;
            if (curPos > fileData.Count)
            {
                this.isContinue = false;
                return;
            }
            if (this.curSP == null)
            {
                this.curSP = (DataGridViewTextBoxCell)this.spData.Rows[0].Cells[0];
            }
            if (curPos == fileData.Count)
            {
                sendData = Message.getFileMessage(fileData[0], this.type, this.version, curSP.RowIndex, curSP.ColumnIndex, 0 + 1);
            }else{
                sendData = Message.getFileMessage(fileData[curPos], this.type, this.version, curSP.RowIndex, curSP.ColumnIndex, curPos + 1);
            }
            if (bUpdate)
            {
                udpClient.Send(sendData, sendData.Length, remotePoint);
            }
            else
            {
                this.serialPort1.Write(sendData, 0, sendData.Length);
            }
            
            curPos += 1;
        }

        private void sendToSp6()
        {
            if (!isContinue)
            {
                if (spList.Count == 0)
                {
                    MessageBox.Show("所选SP已经全部更新完成", "提示");
                    resetFunc();
                    return;
                }
                this.curSP = spList.Dequeue();
                this.curPos = startPos;
                isContinue = true;
            }
            sendFileData();
        }

        private void getAllSelectSp6()
        {
            foreach(DataGridViewTextBoxCell cell in this.spData.SelectedCells){
                cell.Style.BackColor = Color.Gray;
                this.spList.Enqueue(cell);
            }
            this.spData.ClearSelection();
        }

        private void serialPort_DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int n = this.serialPort1.BytesToRead;
                byte[] rbuf = new byte[n];
                this.serialPort1.Read(rbuf, 0, n);
                for(int i = 0; i < rbuf.Length; i++)
                {
                    this.receiveBuf.Add(rbuf[i]);
                    if (this.receiveBuf.Count != 1 && this.receiveBuf[this.receiveBuf.Count - 1] == 0xc0)
                    {
                        byte[] buf = this.receiveBuf.ToArray();
                        int rtype = Message.checkReceiveData(buf);
                        if (rtype == 1)
                        {
                            if (buf[1] == 0x01 || buf[2] == 0x00)
                            {
                                this.isContinue = false;
                            }
                            if(this.type == 2)
                            {
                                sendToSp6();
                            }
                            else
                            {
                                sendFileData();
                            }
                        }
                        else if(rtype == 2)
                        {
                            byte[] result = Message.getSP6SelfCheckMessage();
                            this.serialPort1.Write(result, 0, result.Length);
                        }
                        this.Invoke(disp_result, buf, rtype);
                        this.receiveBuf.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void displayUI(byte[] receive, int rtype)
        {
            this.label21.Text = BitConverter.ToString(receive);
            if(rtype == 1)
            {
                if(this.type == 2)
                {
                    if(receive[1] == 0x01)
                    {
                        this.curSP.Style.BackColor = Color.SpringGreen;
                    }
                    if(receive[2] == 0x00)
                    {
                        this.curSP.Style.BackColor = Color.Red;
                    }
                    if(this.curPos == 0)
                    {
                        return;
                    }
                    this.curSPLabel.Text = String.Format("当前行{0}, 列{1}", curSP.RowIndex + 1, curSP.ColumnIndex + 1);
                }
                else
                {
                    if(receive[1] == 0x01)
                    {
                        this.ZYNQLabel.BackColor = Color.SpringGreen;
                    }
                    if(receive[2] == 0x00)
                    {
                        this.ZYNQLabel.BackColor = Color.Red;
                    }
                    this.curSPLabel.Text = String.Format("当前更新ZYNQ");
                }
                //MessageBox.Show(String.Format("当前帧序号：{0}，一共帧个数：{1}", this.curPos, this.fileData.Count), "提示");
                this.sendPB.Value = (int)(((this.curPos-1) / (float)this.fileData.Count) * 100);
            }else if(rtype == 2){
                int version = (int)receive[6];
                this.ZYNQLabel.Text = parseVersion(version);
                this.ZYNQLabel.BackColor = Color.Yellow;
            }
            else
            {
                for(int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        int versionPos = (i * 8 + j) + 16;
                        int version = (int)receive[versionPos];
                        int colorFlag = (int)receive[8 + i];
                        Color c = Color.White;
                        if (colorFlag - 1 < j)
                        {
                            c = Color.Yellow;
                        }
                        this.spData.Rows[j].Cells[i].Value = parseVersion(version);
                        this.spData.Rows[j].Cells[i].Style.BackColor = c;
                    }
                }
            }
        }

        private void selfCheckBtn_Click(object sender, EventArgs e)
        {
            
            byte[] result = Message.getZYNQSelfCheckMessage();
            //byte[] result = Message.getSP6SelfCheckMessage();
            if (bUpdate)
            {
                udpClient.Send(result, result.Length, remotePoint);
            }
            else
            {
                if (!this.serialPort1.IsOpen)
                {
                    MessageBox.Show("串口未打开", "警告");
                    return;
                }
                this.serialPort1.Write(result, 0, result.Length);
            }
           
        }

        private void spData_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.fileName = fileDialog.FileName;
                this.fileLabel.Text = fileDialog.SafeFileName;
            }
            if (String.IsNullOrEmpty(this.fileName))
            {
                MessageBox.Show("未选择文件", "警告");
                return;
            }
            fileData.Clear();
            startPos = 1;
            BinaryReader br = new BinaryReader(new FileStream(this.fileName, FileMode.Open));
            while (true)
            {
                byte[] temp = br.ReadBytes(256);
                if (temp.Length < 256)
                {
                    if (temp.Length != 0)
                    {
                        byte[] t = new byte[256];
                        for (int i = 0; i < 256; i++)
                        {
                            if (i < temp.Length)
                            {
                                t[i] = temp[i];
                                continue;
                            }
                            t[i] = 0xff;
                        }
                        fileData.Add(t);
                    }
                    break;
                }
                fileData.Add(temp);
            }
            if (fileData.Count == 1)
            {
                startPos = 0;
            }
            br.Close();
        }

        private void sendZYNQBtn_Click(object sender, EventArgs e)
        {
            getVersion();
            if (this.version == -1)
            {
                MessageBox.Show("请输入版本号", "警告");
                return;
            }
            this.type = 1;
            this.curPos = this.startPos;
            sendFileData();
        }

        private void getVersion()
        {
            /*
            string[] versionArray = this.versionTB.Text.Split('.');
            if(versionArray.Length != 2)
            {
                MessageBox.Show("版本号不合法", "警告");
                return;
            }
            this.version = Int32.Parse(versionArray[0]) * 16 + Int32.Parse(versionArray[1]);
            */
        }
        private string parseVersion(int ver) {
            string high = (ver / 16).ToString();
            string low = (ver % 16).ToString();
            return String.Format("{0}.{1}", high, low);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetFunc();
        }

        private void resetFunc()
        {
            this.spList.Clear();
            this.isContinue = true;
            this.curSP = null;
            this.curPos = startPos;
        }

        private void ParityCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DataBitCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BaudRateCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PortNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bUpdate = true;
            //SendData();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                this.serialPanel.Visible = false;
                this.netPanel.Visible = true;
                bUpdate = true;
                this.serialPort1.Close();
            }
            if(comboBox1.SelectedIndex == 1)
            {
                this.serialPanel.Visible = true;
                this.netPanel.Visible = false;
                bUpdate = false;
            }
        }
    }
}
