#define CONNECT_WITH_UPDATE
//#define CONNECT_BY_CONSTRUCTOR

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiwinRobot
{
    public enum BluetoothSendDataType
    {
        descartesPosition,
        jointPosition,
        state
    }

    /// <summary>
    /// 藍牙手臂控制介面。
    /// </summary>
    public interface IBluetoothController : IDevice
    {
        /// <summary>
        /// 訊息處理器。
        /// </summary>
        IMessage Message { get; set; }

        void Send(BluetoothSendDataType dataType, double[] value);
    }

    /// <summary>
    /// 藍牙手臂控制介面。
    /// </summary>
    public class BluetoothArmController : IBluetoothController
    {
        private IMessage _Message;
        private IArmController Arm = null;

        private ISerialPortDevice SerialPortDevice = null;

        /// <summary>
        /// 記得要使用 Connect() 進行連線。
        /// </summary>
        /// <param name="comPort"></param>
        public BluetoothArmController(string comPort, IArmController armControl)
        {
            Arm = armControl;

            SerialPort sp = new SerialPort() { PortName = comPort, BaudRate = 38400 };
            sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            SerialPortDevice = new SerialPortDevice(sp);

            Message = new ErrorMessage();

#if (CONNECT_BY_CONSTRUCTOR)
            Connect();
#endif
        }

        public bool Connected
        {
            get => SerialPortDevice.Connected;
        }

        public IMessage Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
                SerialPortDevice.Message = value;
            }
        }

        public bool Connect()
        {
            bool state = SerialPortDevice.Connect();
#if (CONNECT_WITH_UPDATE)
            if (this.Connected && Arm.Connected)
            {
                Send(BluetoothSendDataType.descartesPosition,
                     Arm.GetPosition(PositionType.Descartes));
            }
#endif
            return state;
        }

        public bool Disconnect()
        {
            return SerialPortDevice.Disconnect();
        }

        public void Send(BluetoothSendDataType dataType, double[] value)
        {
            int[] newValue = new int[value.Length];
            for (int index = 0; index < value.Length; index++)
            {
                newValue[index] = ((int)Math.Round(value[index]));
            }

            switch (dataType)
            {
                case BluetoothSendDataType.descartesPosition:
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
                        SerialPortDevice.SerialPort.Write(data, 0, data.Length);
                    }
                    break;

                case BluetoothSendDataType.jointPosition:
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
                        SerialPortDevice.SerialPort.Write(data, 0, data.Length);
                    }
                    break;

                case BluetoothSendDataType.state:
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
                        SerialPortDevice.SerialPort.Write(data, 0, data.Length);
                    }
                    break;

                default:
                    break;
            }
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

        /// <summary>
        /// Serial Port 接收事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            string indata = serialPort.ReadLine();

            Decoder(indata);
        }

        private void Decoder(string data)
        {
            data = data.Trim();
            double value;

            switch (data.Substring(0, 2))
            {
                case "xr":
                    value = Convert.ToDouble(data.Split('r')[1]);
                    Arm.MotionLinear(new double[] { value, 0, 0, 0, 0, 0 },
                                        PositionType.Descartes,
                                        CoordinateType.Relative);
                    break;

                case "yr":
                    value = Convert.ToDouble(data.Split('r')[1]);
                    Arm.MotionLinear(new double[] { 0, value, 0, 0, 0, 0 },
                                        PositionType.Descartes,
                                        CoordinateType.Relative);
                    break;

                case "zr":
                    value = Convert.ToDouble(data.Split('r')[1]);
                    Arm.MotionLinear(new double[] { 0, 0, value, 0, 0, 0 },
                                        PositionType.Descartes,
                                        CoordinateType.Relative);
                    break;

                case "ud":
                    break;

                default:
                    _Message.Show($"Unknown data: {data}");
                    break;
            }
            Send(BluetoothSendDataType.descartesPosition,
                 Arm.GetPosition(PositionType.Descartes));
        }
    }
}