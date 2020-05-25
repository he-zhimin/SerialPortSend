namespace SerialPortSend
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.portNameCB = new System.Windows.Forms.ComboBox();
            this.baudRateCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.selfCheckBtn = new System.Windows.Forms.Button();
            this.spData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBitCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stopBitCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.parityCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.sendPB = new System.Windows.Forms.ProgressBar();
            this.curSPLabel = new System.Windows.Forms.Label();
            this.sendZYNQBtn = new System.Windows.Forms.Button();
            this.versionTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZYNQLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPanel = new System.Windows.Forms.Panel();
            this.netPanel = new System.Windows.Forms.Panel();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.portTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.serialPanel.SuspendLayout();
            this.netPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口：";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // portNameCB
            // 
            this.portNameCB.FormattingEnabled = true;
            this.portNameCB.Location = new System.Drawing.Point(90, 16);
            this.portNameCB.Name = "portNameCB";
            this.portNameCB.Size = new System.Drawing.Size(61, 20);
            this.portNameCB.TabIndex = 1;
            this.portNameCB.SelectedIndexChanged += new System.EventHandler(this.PortNameCB_SelectedIndexChanged);
            // 
            // baudRateCB
            // 
            this.baudRateCB.FormattingEnabled = true;
            this.baudRateCB.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateCB.Location = new System.Drawing.Point(90, 51);
            this.baudRateCB.Name = "baudRateCB";
            this.baudRateCB.Size = new System.Drawing.Size(61, 20);
            this.baudRateCB.TabIndex = 3;
            this.baudRateCB.SelectedIndexChanged += new System.EventHandler(this.BaudRateCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率：";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(71, 185);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(62, 26);
            this.openBtn.TabIndex = 4;
            this.openBtn.Text = "打开串口";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(14, 354);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(191, 23);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "更新选择的子阵";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // selfCheckBtn
            // 
            this.selfCheckBtn.Location = new System.Drawing.Point(16, 465);
            this.selfCheckBtn.Name = "selfCheckBtn";
            this.selfCheckBtn.Size = new System.Drawing.Size(191, 23);
            this.selfCheckBtn.TabIndex = 6;
            this.selfCheckBtn.Text = "发送自检命令";
            this.selfCheckBtn.UseVisualStyleBackColor = true;
            this.selfCheckBtn.Click += new System.EventHandler(this.selfCheckBtn_Click);
            // 
            // spData
            // 
            this.spData.AllowUserToAddRows = false;
            this.spData.AllowUserToDeleteRows = false;
            this.spData.AllowUserToResizeColumns = false;
            this.spData.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.spData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.spData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.spData.Location = new System.Drawing.Point(26, 20);
            this.spData.Name = "spData";
            this.spData.ReadOnly = true;
            this.spData.RowTemplate.Height = 45;
            this.spData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.spData.Size = new System.Drawing.Size(683, 382);
            this.spData.TabIndex = 8;
            this.spData.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.spData_RowStateChanged);
            // 
            // Column1
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column1.HeaderText = "1L";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column2.HeaderText = "2L";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column3.HeaderText = "3L";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column4.HeaderText = "4L";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column5.HeaderText = "5L";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column6.HeaderText = "6L";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column7.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column7.HeaderText = "7L";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column8.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column8.HeaderText = "8L";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 80;
            // 
            // dataBitCB
            // 
            this.dataBitCB.FormattingEnabled = true;
            this.dataBitCB.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBitCB.Location = new System.Drawing.Point(90, 83);
            this.dataBitCB.Name = "dataBitCB";
            this.dataBitCB.Size = new System.Drawing.Size(61, 20);
            this.dataBitCB.TabIndex = 10;
            this.dataBitCB.SelectedIndexChanged += new System.EventHandler(this.DataBitCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "数据位：";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // stopBitCB
            // 
            this.stopBitCB.FormattingEnabled = true;
            this.stopBitCB.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBitCB.Location = new System.Drawing.Point(90, 117);
            this.stopBitCB.Name = "stopBitCB";
            this.stopBitCB.Size = new System.Drawing.Size(61, 20);
            this.stopBitCB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "停止位：";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // parityCB
            // 
            this.parityCB.FormattingEnabled = true;
            this.parityCB.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityCB.Location = new System.Drawing.Point(90, 150);
            this.parityCB.Name = "parityCB";
            this.parityCB.Size = new System.Drawing.Size(61, 20);
            this.parityCB.TabIndex = 14;
            this.parityCB.SelectedIndexChanged += new System.EventHandler(this.ParityCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "奇偶校验：";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(14, 298);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(78, 23);
            this.openFileBtn.TabIndex = 15;
            this.openFileBtn.Text = "选择文件";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(101, 303);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(0, 12);
            this.fileLabel.TabIndex = 16;
            // 
            // sendPB
            // 
            this.sendPB.Location = new System.Drawing.Point(442, 544);
            this.sendPB.Name = "sendPB";
            this.sendPB.Size = new System.Drawing.Size(480, 23);
            this.sendPB.Step = 1;
            this.sendPB.TabIndex = 17;
            // 
            // curSPLabel
            // 
            this.curSPLabel.AutoSize = true;
            this.curSPLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.curSPLabel.Location = new System.Drawing.Point(640, 550);
            this.curSPLabel.Name = "curSPLabel";
            this.curSPLabel.Size = new System.Drawing.Size(0, 12);
            this.curSPLabel.TabIndex = 18;
            // 
            // sendZYNQBtn
            // 
            this.sendZYNQBtn.Location = new System.Drawing.Point(14, 382);
            this.sendZYNQBtn.Name = "sendZYNQBtn";
            this.sendZYNQBtn.Size = new System.Drawing.Size(191, 23);
            this.sendZYNQBtn.TabIndex = 19;
            this.sendZYNQBtn.Text = "更新主控";
            this.sendZYNQBtn.UseVisualStyleBackColor = true;
            this.sendZYNQBtn.Click += new System.EventHandler(this.sendZYNQBtn_Click);
            // 
            // versionTB
            // 
            this.versionTB.Location = new System.Drawing.Point(82, 326);
            this.versionTB.Name = "versionTB";
            this.versionTB.Size = new System.Drawing.Size(123, 21);
            this.versionTB.TabIndex = 20;
            this.versionTB.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "版本号：";
            this.label5.Visible = false;
            // 
            // ZYNQLabel
            // 
            this.ZYNQLabel.AutoSize = true;
            this.ZYNQLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZYNQLabel.Location = new System.Drawing.Point(189, 424);
            this.ZYNQLabel.MinimumSize = new System.Drawing.Size(400, 30);
            this.ZYNQLabel.Name = "ZYNQLabel";
            this.ZYNQLabel.Size = new System.Drawing.Size(400, 30);
            this.ZYNQLabel.TabIndex = 22;
            this.ZYNQLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "在线状态";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "更新失败";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "更新完成";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.SpringGreen;
            this.label13.Location = new System.Drawing.Point(14, 534);
            this.label13.MinimumSize = new System.Drawing.Size(53, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(14, 559);
            this.label15.MinimumSize = new System.Drawing.Size(53, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(14, 503);
            this.label16.MinimumSize = new System.Drawing.Size(53, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 28;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(16, 425);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(191, 23);
            this.resetBtn.TabIndex = 33;
            this.resetBtn.Text = "更新重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(373, 550);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 34;
            this.label17.Text = "更新进度";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(130, 433);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 35;
            this.label18.Text = "主控状态";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spData);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ZYNQLabel);
            this.groupBox1.Location = new System.Drawing.Point(293, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 476);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "子阵坐标和主控图示";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(160, 588);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 12);
            this.label21.TabIndex = 39;
            this.label21.Text = "label21";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-119, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 26);
            this.button1.TabIndex = 41;
            this.button1.Text = "打开网口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "网口",
            "串口"});
            this.comboBox1.Location = new System.Drawing.Point(53, 12);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 20);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // serialPanel
            // 
            this.serialPanel.Controls.Add(this.label2);
            this.serialPanel.Controls.Add(this.label1);
            this.serialPanel.Controls.Add(this.portNameCB);
            this.serialPanel.Controls.Add(this.baudRateCB);
            this.serialPanel.Controls.Add(this.openBtn);
            this.serialPanel.Controls.Add(this.label3);
            this.serialPanel.Controls.Add(this.dataBitCB);
            this.serialPanel.Controls.Add(this.label4);
            this.serialPanel.Controls.Add(this.stopBitCB);
            this.serialPanel.Controls.Add(this.label6);
            this.serialPanel.Controls.Add(this.parityCB);
            this.serialPanel.Location = new System.Drawing.Point(12, 56);
            this.serialPanel.Name = "serialPanel";
            this.serialPanel.Size = new System.Drawing.Size(191, 223);
            this.serialPanel.TabIndex = 43;
            // 
            // netPanel
            // 
            this.netPanel.Controls.Add(this.label12);
            this.netPanel.Controls.Add(this.label11);
            this.netPanel.Controls.Add(this.label9);
            this.netPanel.Controls.Add(this.portTB);
            this.netPanel.Controls.Add(this.ipTB);
            this.netPanel.Location = new System.Drawing.Point(12, 54);
            this.netPanel.Name = "netPanel";
            this.netPanel.Size = new System.Drawing.Size(191, 152);
            this.netPanel.TabIndex = 44;
            // 
            // ipTB
            // 
            this.ipTB.Location = new System.Drawing.Point(68, 18);
            this.ipTB.Name = "ipTB";
            this.ipTB.ReadOnly = true;
            this.ipTB.Size = new System.Drawing.Size(100, 21);
            this.ipTB.TabIndex = 0;
            this.ipTB.Text = "192.168.1.10";
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(68, 59);
            this.portTB.Name = "portTB";
            this.portTB.ReadOnly = true;
            this.portTB.Size = new System.Drawing.Size(100, 21);
            this.portTB.TabIndex = 1;
            this.portTB.Text = "7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "主控 ip";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "主控端口";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 100);
            this.label12.MaximumSize = new System.Drawing.Size(150, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "请将本机ip改为   192.168.1.100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 625);
            this.Controls.Add(this.netPanel);
            this.Controls.Add(this.serialPanel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.versionTB);
            this.Controls.Add(this.sendZYNQBtn);
            this.Controls.Add(this.curSPLabel);
            this.Controls.Add(this.sendPB);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.selfCheckBtn);
            this.Controls.Add(this.sendBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.serialPanel.ResumeLayout(false);
            this.serialPanel.PerformLayout();
            this.netPanel.ResumeLayout(false);
            this.netPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portNameCB;
        private System.Windows.Forms.ComboBox baudRateCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button selfCheckBtn;
        private System.Windows.Forms.DataGridView spData;
        private System.Windows.Forms.ComboBox dataBitCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stopBitCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox parityCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.ProgressBar sendPB;
        private System.Windows.Forms.Label curSPLabel;
        private System.Windows.Forms.Button sendZYNQBtn;
        private System.Windows.Forms.TextBox versionTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ZYNQLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel serialPanel;
        private System.Windows.Forms.Panel netPanel;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}

