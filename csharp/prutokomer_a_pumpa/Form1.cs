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
using System.Globalization;
using System.IO;
using Newtonsoft.Json;

namespace prutokomer_a_pumpa
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private SerialPort serialPort2;
        private bool recording = false;
        private StreamWriter textfile;
        private decimal period = 0.05m;
        //private decimal maxShowSamples = 600;
        private decimal maxShowSamples = 800;
        private decimal t;
        private CultureInfo enUS = new CultureInfo("en-US");

        public Form1()
        {
            InitializeComponent();
            //openFlowSerial();
            openPumpSerial();

        }

        private void COM_flow_Click(object sender, EventArgs e)
        {
            openFlowSerial();
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
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerFlow);
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
        private void DataReceivedHandlerFlow(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine().Substring(1).Trim();

            if (checkBox_showPlot.Checked)
            {
                decimal data = Convert.ToDecimal(indata, enUS);

                t = t + period;

                chart_flow.BeginInvoke((MethodInvoker)delegate
                {
                    chart_flow.Series[0].Points.AddXY(t, data);
                    if (chart_flow.Series[0].Points.Count > maxShowSamples)
                    {
                        chart_flow.Series[0].Points.RemoveAt(0);

                    }
                    chart_flow.ChartAreas[0].RecalculateAxesScale();
                });
            }



            if (recording)
            {
                if (textfile.BaseStream != null)
                {
                    string to_write = DateTime.Now.ToString("HH:mm:ss.fff");
                    to_write += ";" + indata + "\n";
                    textfile.Write(to_write);
                    Console.Write(to_write);
                }
            }

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("cs-CZ");
            string filename = Path.Combine(textBox_filename.Text + '_' + time.ToString().Replace(".", "_").Replace(":", "_").Replace(" ", "_") + ".txt");

            textfile = new StreamWriter(filename);
            recording = true;

            button_start.Enabled = false;
            button_stop.Enabled = true;
            textBox_filename.Enabled = false;

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            recording = false;
            textfile.Close();

            button_start.Enabled = true;
            button_stop.Enabled = false;
            textBox_filename.Enabled = true;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPlot.Checked)
            {
                this.chart_flow.BeginInvoke((MethodInvoker)delegate
                {
                    chart_flow.Series[0].Points.Clear();
                    t = 0m;
                });
            }



        }

        private void label_COM_pump_Click(object sender, EventArgs e)
        {
            openPumpSerial();
        }


        private void openPumpSerial()
        {
            label_COM_pump.Text = "Connecting";
            label_COM_pump.ForeColor = System.Drawing.Color.Gray;

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
                    serialPort2 = new SerialPort(port, 115200);

                    serialPort2.Open();
                    serialPort2.WriteTimeout = 1000;
                    serialPort2.ReadTimeout = 1000;

                    Thread.Sleep(100);

                    serialPort2.WriteLine("1 status");
                    string message1 = serialPort2.ReadLine();


                    Console.WriteLine(message1.Trim().Substring(2));

                    if (message1.Trim().Substring(2).Equals("status"))
                    {
                        label_COM_pump.Text = port;
                        label_COM_pump.ForeColor = System.Drawing.Color.Green;
                        serialPort2.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerPump);
                        return;
                    }
                    else
                    {
                        serialPort2.Close();

                    }

                }
                catch (TimeoutException)
                {
                    Console.WriteLine("time out");
                    serialPort2.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    serialPort2.Close();
                }
            }
            label_COM_pump.Text = "NA";
            label_COM_pump.ForeColor = System.Drawing.Color.Red;
        }


        private void DataReceivedHandlerPump(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine().Trim();

            Console.WriteLine(indata);

            string to_write = DateTime.Now.ToString("HH:mm:ss.fff");

            this.listBox_pump_comunication.BeginInvoke((MethodInvoker)delegate
            {
                listBox_pump_comunication.BeginUpdate();
                listBox_pump_comunication.Items.Add(to_write + ": " +indata);
                if (listBox_pump_comunication.Items.Count > 7)
                {
                    listBox_pump_comunication.Items.RemoveAt(0);
                }
                listBox_pump_comunication.EndUpdate();
            });


        }

        private void button_stop_without_recording_Click(object sender, EventArgs e)
        {
            serialPort2.WriteLine("1 stop");
        }

        private void button_start_without_recording_Click(object sender, EventArgs e)
        {
            serialPort2.WriteLine("1 start");
        }

        private void checkBox_1_CheckedChanged(object sender, EventArgs e)
        {





        }


        public class JsonData
        {
            public decimal gain { get; set; }

        }


        private void button_save_settings_Click(object sender, EventArgs e)
        {

            JsonData jsonData = new JsonData();

            jsonData.gain = 5m;


            string json = JsonConvert.SerializeObject(jsonData);
            File.WriteAllText("settings.json", json);

        }

        private void button_load_setttings_Click(object sender, EventArgs e)
        {
            string json_loaded = File.ReadAllText("settings.json");

            JsonData jsonData_loaded = JsonConvert.DeserializeObject<JsonData>(json_loaded);

            decimal five = jsonData_loaded.gain;
        }
    }

}
