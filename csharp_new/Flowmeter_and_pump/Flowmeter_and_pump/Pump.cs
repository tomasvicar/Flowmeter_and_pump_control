using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowmeter_and_pump
{
    class Pump
    {
        public Form1 form;
        private ISerialPort serialPort;
        //private SerialPort serialPort;
        private CultureInfo enUS = new CultureInfo("en-US");
        private string actulaPump;
        public string header;
        public Pump(Form1 form)
        {
            this.form = form;
        }

        public void openPumpSerial()
        {
            UpdateLabel(form.label_COM_pump, "Connecting", System.Drawing.Color.Gray);


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
                    serialPort = new SerialPortAdapter(port, 115200);
                    //serialPort = new SerialPort(port, 115200);
                    serialPort.DataBits = 8;
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;
                    serialPort.NewLine = "\r\n";

                    serialPort.Open();
                    serialPort.WriteTimeout = 500;
                    serialPort.ReadTimeout = 500;


                    Thread.Sleep(100);

                    serialPort.WriteLine("1 status");
                    string message1 = serialPort.ReadLine();
                    Console.WriteLine(message1);

                    if (message1.Trim().Substring(2).Equals("status"))
                    {
                        UpdateLabel(form.label_COM_pump, port, System.Drawing.Color.Green);
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerPump);
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
            UpdateLabel(form.label_COM_pump, "NA", System.Drawing.Color.Red);
        }


        private void DataReceivedHandlerPump(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine();

                Console.WriteLine(indata);



                string to_write = DateTime.Now.ToString("HH:mm:ss.fff");

                form.listBox_pump_comunication.BeginInvoke((MethodInvoker)delegate
                {
                    form.listBox_pump_comunication.BeginUpdate();
                    form.listBox_pump_comunication.Items.Add(to_write + ": " + indata);
                    if (form.listBox_pump_comunication.Items.Count > 10)
                    {
                        form.listBox_pump_comunication.Items.RemoveAt(0);
                    }
                    form.listBox_pump_comunication.EndUpdate();
                });

            }
            catch
            {

            }

        }


        public void run()
        {
            serialPort.WriteLine(actulaPump + " start 1 ");
        }
        public void stop()
        {
            serialPort.WriteLine(actulaPump + " pause ");
        }




        public string activateSequence(List<MetroLabel> label_list_names, List<MetroLabel> label_list_values, List<MetroCheckBox> label_list_checkboxes, MetroCheckBox sender)
        {
            string label_value = "";
            for (int i = 0; i < label_list_checkboxes.Count; i++)
            {
                if (label_list_checkboxes[i] == sender)
                {
                    label_value = label_list_values[i].Text;
                    break;
                }
            }

            var tmp = label_value.Split(new string[] { "    " }, StringSplitOptions.None);
            string sequence = tmp[0];
            actulaPump = tmp[3].Replace("pump ", "");



            Tuple<List<double>, List<double>, List<double>> tmp2 = FormSequence.split_sequence(sequence);
            List<double> delays = tmp2.Item1;
            List<double> times = tmp2.Item2;
            List<double> rates = tmp2.Item3;

            form.req_time = (float)(times.Sum() + delays.Sum() + float.Parse(form.textBox_time_reserve_s.Text, enUS));


            string rates_ml = "";
            for (int i = 0; i < rates.Count; i++)
            {
                rates_ml = rates_ml + (float.Parse(form.textBox_pa_is_xx_ml_min.Text, enUS) * rates[i]).ToString("0.00", enUS) + ",";
            }
            rates_ml = rates_ml.Substring(0, rates_ml.Length - 1);


            string volumes_ml = "";
            for (int i = 0; i < rates.Count; i++)
            {
                volumes_ml = volumes_ml + (float.Parse(form.textBox_pa_is_xx_ml_min.Text, enUS) * times[i] * rates[i] / 60).ToString("0.00", enUS) + ",";
            }
            volumes_ml = volumes_ml.Substring(0, volumes_ml.Length - 1);


            string times_string = "";
            for (int i = 0; i < times.Count; i++)
            {
                times_string = times_string + times[i].ToString("0.00", enUS) + ",";
            }
            times_string = times_string.Substring(0, times_string.Length - 1);


            string delays_string = "";
            for (int i = 0; i < times.Count; i++)
            {
                delays_string = delays_string + delays[i].ToString("0.00", enUS) + ",";
            }
            delays_string = delays_string.Substring(0, delays_string.Length - 1);

            string rates_string = "";
            for (int i = 0; i < times.Count; i++)
            {
                rates_string = rates_string + rates[i].ToString("0.00", enUS) + ",";
            }
            rates_string = rates_string.Substring(0, rates_string.Length - 1);


            serialPort.WriteLine(actulaPump + " set units 0");
            Thread.Sleep(1000);
            serialPort.WriteLine(actulaPump + " set diameter " + form.textBox_diameter.Text);
            Thread.Sleep(1000);
            //serialPort2.WriteLine(actulaPump + " set time " + textBox_times3.Text);
            serialPort.WriteLine(actulaPump + " set volume " + volumes_ml);
            Thread.Sleep(1000);
            serialPort.WriteLine(actulaPump + " set rate " + rates_ml);
            Thread.Sleep(1000);
            serialPort.WriteLine(actulaPump + " set delay " + delays_string);




            header = "";
            header += "times " + times_string + "\n";
            header += "rates_ml/min " + rates_ml + "\n";
            header += "rates_Pa " + rates_string + "\n";
            header += "volumes " + volumes_ml + "\n";
            header += "delays " + delays_string + "\n";

            return header;
        }




        public void openVirtualPumpSerial()
        {
            UpdateLabel(form.label_COM_pump, "Connecting", System.Drawing.Color.Gray);


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
                    //serialPort = new SerialPort(port, 115200);
                    serialPort = new VirtualSerialPort(port, 115200);
                    serialPort.DataBits = 8;
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;
                    serialPort.WriteTimeout = 500;
                    serialPort.ReadTimeout = 500;
                    serialPort.NewLine = "\r\n";


                    serialPort.Open();
                    Thread.Sleep(4000);

                    serialPort.WriteLine("ko?");
                    string message1 = serialPort.ReadLine();
                    Console.WriteLine(message1);

                    if (message1.Trim() == "ok")
                    {
                        UpdateLabel(form.label_COM_pump, port, System.Drawing.Color.Green);
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerPump);
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
            UpdateLabel(form.label_COM_pump, "NA", System.Drawing.Color.Red);

        }

        private void DataReceivedHandlerVirtualPump(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine();

                Console.WriteLine(indata);



                string to_write = DateTime.Now.ToString("HH:mm:ss.fff");

                form.listBox_pump_comunication.BeginInvoke((MethodInvoker)delegate
                {
                    form.listBox_pump_comunication.BeginUpdate();
                    form.listBox_pump_comunication.Items.Add(to_write + ": " + indata);
                    if (form.listBox_pump_comunication.Items.Count > 10)
                    {
                        form.listBox_pump_comunication.Items.RemoveAt(0);
                    }
                    form.listBox_pump_comunication.EndUpdate();
                });

            }
            catch
            {

            }

        }


        private void UpdateLabel(Label label, string text, System.Drawing.Color color)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => UpdateLabel(label, text, color)));
            }
            else
            {
                label.Text = text;
                label.ForeColor = color;
                label.Refresh();
            }
        }
    }

}
