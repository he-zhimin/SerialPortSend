using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortSend
{
    static class Message
    {
        static public byte[] getSP6SelfCheckMessage()
        {
            byte[] result = { 0xc0, 0x03, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0xc0 };
            genCheckByte(result);
            return result;
        }

        static public byte[] getZYNQSelfCheckMessage()
        {
            byte[] result = { 0xc0, 0x04, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0xc0 };
            genCheckByte(result);
            return result;
        }

        static public byte[] getFileMessage(byte[] data, int type, int version, int row, int column, int curPos)
        {
            byte[] result = new byte[266];
            result[0] = 0xc0;
            result[1] = (byte)type;
            result[2] = (byte)row;
            result[3] = (byte)column;
            result[4] = (byte)version;
            result[5] = 0x00;
            result[6] = (byte)(curPos / 256);
            result[7] = (byte)(curPos % 256);
            for (int i = 0; i < 256; i++)
            {
                result[8 + i] = data[i];
            }
            result[265] = 0xc0;
            genCheckByte(result);
            byte[] transResult = transByte(result);
            return transResult;
        }

        static private void genCheckByte(byte[] result)
        {
            byte temp = 0x00;
            for (int i = 1; i < result.Length - 2; i++)
            {
                temp = (byte)(temp ^ result[i]);
            }
            result[result.Length - 2] = temp;
        }

        static private byte[] transByte(byte[] data)
        {
            List<byte> temp = new List<byte>();
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] == 0xc0)
                {
                    temp.Add(0xdb);
                    temp.Add(0xdc);
                }
                else if(data[i] == 0xdb)
                {
                    temp.Add(0xdb);
                    temp.Add(0xdd);
                }
                else
                {
                    temp.Add(data[i]);
                }

            }
            return temp.ToArray();
        }
        static public int checkReceiveData(byte[] receiveData)
        {
            if (receiveData.Length == 4)
            {
                return 1;
            }else if(receiveData.Length == 10){
                return 2;
            }
            return 3;
        }
    }
}
