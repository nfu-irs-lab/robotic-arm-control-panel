//#define CONNECT_BY_CONSTRUCTOR

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIWIN_Robot
{
    internal class BluetoothControl : SerialPortDevice
    {
        public double MotionValue = 50;

        private ArmControl Arm = new ArmControl(Configuration.ArmIP);

        /// <summary>
        /// 記得要使用 Connect() 進行連線。
        /// </summary>
        /// <param name="COMPort"></param>
        public BluetoothControl(string COMPort, int armID = 0)
            : base(new SerialPort() { PortName = COMPort, BaudRate = 38400 })
        {
            sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            Arm.SetID(armID);

#if (CONNECT_BY_CONSTRUCTOR)
            Connect();
#endif
        }

        public enum DataType
        {
            descartesPosition,
            jointPosition,
            state
        }

        public void Send(DataType dataType, double[] value)
        {
            int[] newValue = new int[value.Length];
            for (int index = 0; index < value.Length; index++)
            {
                newValue[index] = ((int)Math.Round(value[index]));
            }

            switch (dataType)
            {
                case DataType.descartesPosition:
                    if (newValue.Length == 6)
                    {
                        var xValue = ConvertIntToByte(newValue[0]);
                        var yValue = ConvertIntToByte(newValue[1]);
                        var zValue = ConvertIntToByte(newValue[2]);
                        var aValue = ConvertIntToByte(newValue[3]);
                        var bValue = ConvertIntToByte(newValue[4]);
                        var cValue = ConvertIntToByte(newValue[5]);

                        byte[] data = new byte[]
                        {
                            0xff,
                            0x01,

                            cValue[1],
                            cValue[0],

                            bValue[1],
                            bValue[0],

                            aValue[1],
                            aValue[0],

                            zValue[1],
                            zValue[0],

                            yValue[1],
                            yValue[0],

                            xValue[1],
                            xValue[0],

                            0xff
                        };
                        sp.Write(data, 0, data.Length);
                    }
                    break;

                case DataType.jointPosition:
                    if (newValue.Length == 6)
                    {
                        var xValue = ConvertIntToByte(newValue[0]);
                        var yValue = ConvertIntToByte(newValue[1]);
                        var zValue = ConvertIntToByte(newValue[2]);
                        var aValue = ConvertIntToByte(newValue[3]);
                        var bValue = ConvertIntToByte(newValue[4]);
                        var cValue = ConvertIntToByte(newValue[5]);

                        byte[] data = new byte[]
                        {
                            0xff,
                            0x02,

                            xValue[1],
                            xValue[0],

                            yValue[1],
                            yValue[0],

                            zValue[1],
                            zValue[0],

                            aValue[1],
                            aValue[0],

                            bValue[1],
                            bValue[0],

                            cValue[1],
                            cValue[0],

                            0xff
                        };
                        sp.Write(data, 0, data.Length);
                    }
                    break;

                case DataType.state:
                    if (newValue.Length == 3)
                    {
                        var speedValue = ConvertIntToByte(newValue[0], 1);
                        var accValue = ConvertIntToByte(newValue[1], 1);
                        byte connectState = (newValue[3] == 0) ? (byte)0 : (byte)1;

                        byte[] data = new byte[]
                        {
                            0xff,
                            0x03,

                            speedValue[0],

                            accValue[0],

                            connectState,

                            0xff
                        };
                        sp.Write(data, 0, data.Length);
                    }
                    break;

                default:
                    break;
            }
        }

        public void UpdateArmID(int armID)
        {
            Arm.SetID(armID);
        }

        private byte[] ConvertIntToByte(int intValue, int count = 2)
        {
            byte[] intByte = BitConverter.GetBytes(intValue);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(intByte);
            }

            byte[] result = new byte[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = intByte[i];
            }
            return result;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            string indata = serialPort.ReadLine();

            Decoder(indata);
        }

        private void Decoder(string data)
        {
            data = data.Trim();

            switch (data)
            {
                case "X":
                    Arm.MotionLinear(new double[] { MotionValue, 0, 0, 0, 0, 0 },
                                        ArmControl.PositionType.descartes,
                                        ArmControl.CoordinateType.relative);
                    break;

                case "x":
                    Arm.MotionLinear(new double[] { -MotionValue, 0, 0, 0, 0, 0 },
                                        ArmControl.PositionType.descartes,
                                        ArmControl.CoordinateType.relative);
                    break;

                case "Y":
                    Arm.MotionLinear(new double[] { 0, MotionValue, 0, 0, 0, 0 },
                                        ArmControl.PositionType.descartes,
                                        ArmControl.CoordinateType.relative);
                    break;

                case "y":
                    Arm.MotionLinear(new double[] { 0, -MotionValue, 0, 0, 0, 0 },
                                        ArmControl.PositionType.descartes,
                                        ArmControl.CoordinateType.relative);
                    break;

                case "Z":
                    Arm.MotionLinear(new double[] { 0, 0, MotionValue, 0, 0, 0 },
                                        ArmControl.PositionType.descartes,
                                        ArmControl.CoordinateType.relative);
                    break;

                case "z":
                    Arm.MotionLinear(new double[] { 0, 0, -MotionValue, 0, 0, 0 },
                                        ArmControl.PositionType.descartes,
                                        ArmControl.CoordinateType.relative);
                    break;

                case "u":
                    break;

                default:
                    MessageBox.Show($"Unknown date: {data}");
                    break;
            }
            Send(DataType.descartesPosition, Arm.GetNowPosition(ArmControl.PositionType.descartes));
        }
    }
}