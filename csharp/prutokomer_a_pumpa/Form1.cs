using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace prutokomer_a_pumpa
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();

            openFlowSerial();
        }

        private void COM_flow_Click(object sender, EventArgs e)
        {

        }
        private void openFlowSerial()
        {
            label_COM_flow.Text = "Connecting";
            label_COM_flow.ForeColor = System.Drawing.Color.Gray;

            string[] arrayComPortsNames = SerialPort.GetPortNames();

            if (!(serialPort == null))
{
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    Thread.Sleep(3000);
                }
            }
            foreach (string port in arrayComPortsNames)
            {
                Console.WriteLine(port);
                try
                {
                    serialPort = new SerialPort(port, 115200);

                    serialPort.Open();
                    serialPort.WriteTimeout = 1000;
                    serialPort.ReadTimeout = 1000;

                    Thread.Sleep(100);
                    string message1 = serialPort.ReadLine();


                    Console.WriteLine(message1);

                    if ((message1.Trim().Length == 7) & message1.StartsWith("F"))
                    {
                        label_COM_flow.Text = port;
                        label_COM_flow.ForeColor = System.Drawing.Color.Green;
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                        return;
                    }
                    else
                    {
                        serialPort.Close();

                    }

                }
                catch (TimeoutException)
                {
                    Console.WriteLine("time out");
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    serialPort.Close();
                }
            }
            label_COM_flow.Text = "NA";
            label_COM_flow.ForeColor = System.Drawing.Color.Red;

        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting().Substring(1).Trim();

            Console.WriteLine(indata);


        }



    }



}
