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
        public BluetoothControl(string COMPort)
            : base(new SerialPort() { PortName = COMPort, BaudRate = 38400 })
        {
            sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

#if (CONNECT_BY_CONSTRUCTOR)
            Connect();
#endif
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

                case "":
                    break;

                default:
                    MessageBox.Show($"Unknown date: {data}");
                    break;
            }
        }
    }
}