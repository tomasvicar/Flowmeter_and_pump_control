using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;

namespace prutokomer_a_pumpa
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        private SerialPort serialPort2;
        private CultureInfo enUS = new CultureInfo("en-US");
        private string actulaPump = "1";
        private DateTime startTime;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private float req_time;
        private Flowmeter flowmeter;


        public Form1()
        {

            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("cs-CZ");
            InitializeComponent();

            SetLoger();
            openPumpSerial();

            flowmeter = new Flowmeter(this);
            flowmeter.openFlowSerial();

            update_filename();
        }
        private void SetLoger()
        {
            string path = "logs";
            DateTime time = DateTime.Now;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filename = Path.Combine(path, "log" + "_" + time.ToString(CultureInfo.GetCultureInfo("cs-CZ")).Replace(".", "_").Replace(":", "_").Replace(" ", "_") + ".txt");

            FileStream filestream = new FileStream(filename, FileMode.Create);
            var streamwriter = new StreamWriter(filestream);
            streamwriter.AutoFlush = true;
            Console.SetOut(streamwriter);
            Console.SetError(streamwriter);

        }

        private void COM_flow_Click(object sender, EventArgs e)
        {
            flowmeter.openFlowSerial();
        }


        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            button_start_without_recording.Enabled = false;
            textBox_filename.Enabled = false;

            flowmeter.startTextFile();


            serialPort2.WriteLine(actulaPump + " start 1 ");


            startTimer();

            button_stop.Enabled = true;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            
            button_stop.Enabled = false;
            textBox_filename.Enabled = true;

            flowmeter.recording = false;
            flowmeter.closeTextfile();

            serialPort2.WriteLine(actulaPump + " pause ");

            timer_stop();

            button_start.Enabled = true;
            button_start_without_recording.Enabled = true;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPlot.Checked)
            {
                this.chart_flow.BeginInvoke((MethodInvoker)delegate
                {
                    chart_flow.Series[0].Points.Clear();
                    flowmeter.resetTime();
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
                    serialPort2.DataBits = 8;
                    serialPort2.Parity = Parity.None;
                    serialPort2.StopBits = StopBits.One;
                    serialPort2.NewLine = "\r\n";

                    serialPort2.Open();
                    serialPort2.WriteTimeout = 500;
                    serialPort2.ReadTimeout = 500;


                    Thread.Sleep(100);

                    serialPort2.WriteLine("1 status");
                    string message1 = serialPort2.ReadLine();
                    Console.WriteLine(message1);

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
            try
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine();

                Console.WriteLine(indata);



                string to_write = DateTime.Now.ToString("HH:mm:ss.fff");

                this.listBox_pump_comunication.BeginInvoke((MethodInvoker)delegate
                {
                    listBox_pump_comunication.BeginUpdate();
                    listBox_pump_comunication.Items.Add(to_write + ": " + indata);
                    if (listBox_pump_comunication.Items.Count > 10)
                    {
                        listBox_pump_comunication.Items.RemoveAt(0);
                    }
                    listBox_pump_comunication.EndUpdate();
                });

            }
            catch
            {

            }

        }

        private void button_stop_without_recording_Click(object sender, EventArgs e)
        {
            
            button_stop_without_recording.Enabled = false;
            serialPort2.WriteLine(actulaPump + " pause ");
            timer_stop();
            button_start_without_recording.Enabled = true;
            button_start.Enabled = true;
        }

        private void button_start_without_recording_Click(object sender, EventArgs e)
        {
            button_start_without_recording.Enabled = false;
            button_start.Enabled = false;

            serialPort2.WriteLine(actulaPump + " start 1 ");
            startTimer();

            button_stop_without_recording.Enabled = true;
        }

        private void checkBox_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1.Checked == true)
            {
                
                checkBox_2.Checked = false;
                checkBox_3.Checked = false;
                checkBox_4.Checked = false;
                update_1();
                button_start.Enabled = true;
                button_start_without_recording.Enabled = true;
            }

        }


        public class JsonData
        {
            public string textBox_rates1 { get; set; }
            public string textBox_times1 { get; set; }
            public string textBox_delays1 { get; set; }
            public string textBox_diameter1 { get; set; }
            public decimal numericUpDown_pump_mum1 { get; set; }

            public string textBox_rates2 { get; set; }
            public string textBox_times2 { get; set; }
            public string textBox_delays2 { get; set; }
            public string textBox_diameter2 { get; set; }
            public decimal numericUpDown_pump_mum2 { get; set; }


            public string textBox_pa_to_ml_min { get; set; }
            public string textBox_time_reserve { get; set; }


            public decimal numericUpDown_number { get; set; }
            public string textBox_experiment { get; set; }
            public decimal numericUpDown_WP { get; set; }
            public decimal numericUpDown_well { get; set; }
            public decimal numericUpDown_FOV { get; set; }
            public string textBox_cells { get; set; }
            public string textBox_well_position { get; set; }
            public string maskedTextBox_date_seeded { get; set; }
            public string textBox_note { get; set; }

        }


        private void button_save_settings_Click(object sender, EventArgs e)
        {

            JsonData jsonData = new JsonData();

            jsonData.textBox_rates1 = textBox_rates1.Text;
            jsonData.textBox_times1 = textBox_times1.Text;
            jsonData.textBox_delays1 = textBox_delays1.Text;
            jsonData.textBox_diameter1 = textBox_diameter1.Text;
            jsonData.numericUpDown_pump_mum1 = numericUpDown_pump_mum1.Value;


            jsonData.textBox_rates2 = textBox_rates2.Text;
            jsonData.textBox_times2 = textBox_times2.Text;
            jsonData.textBox_delays2 = textBox_delays2.Text;
            jsonData.textBox_diameter2 = textBox_diameter2.Text;
            jsonData.numericUpDown_pump_mum2 = numericUpDown_pump_mum2.Value;


            jsonData.textBox_pa_to_ml_min = textBox_pa_to_ml_min.Text;
            jsonData.textBox_time_reserve = textBox_time_reserve.Text;


            jsonData.numericUpDown_number = numericUpDown_number.Value;
            jsonData.textBox_experiment = textBox_experiment.Text;
            jsonData.numericUpDown_WP = numericUpDown_WP.Value;
            jsonData.numericUpDown_well = numericUpDown_well.Value;
            jsonData.numericUpDown_FOV = numericUpDown_FOV.Value;
            jsonData.textBox_cells = textBox_cells.Text;
            jsonData.textBox_well_position = textBox_well_position.Text;
            jsonData.maskedTextBox_date_seeded = maskedTextBox_date_seeded.Text;
            jsonData.textBox_note = textBox_note.Text;


            string json = JsonConvert.SerializeObject(jsonData);
            File.WriteAllText(textBox_filename_settings.Text, json);

        }

        private void button_load_setttings_Click(object sender, EventArgs e)
        {
            string json_loaded = File.ReadAllText(textBox_filename_settings.Text);

            JsonData jsonData_loaded = JsonConvert.DeserializeObject<JsonData>(json_loaded);

            textBox_rates1.Text = jsonData_loaded.textBox_rates1;
            textBox_times1.Text = jsonData_loaded.textBox_times1;
            textBox_delays1.Text = jsonData_loaded.textBox_delays1;
            textBox_diameter1.Text = jsonData_loaded.textBox_diameter1;
            numericUpDown_pump_mum1.Value = jsonData_loaded.numericUpDown_pump_mum1;
            checkBox_1.Checked = false;

            textBox_rates2.Text = jsonData_loaded.textBox_rates2;
            textBox_times2.Text = jsonData_loaded.textBox_times2;
            textBox_delays2.Text = jsonData_loaded.textBox_delays2;
            textBox_diameter2.Text = jsonData_loaded.textBox_diameter2;
            numericUpDown_pump_mum2.Value = jsonData_loaded.numericUpDown_pump_mum2;
            checkBox_2.Checked = false;

            textBox_pa_to_ml_min.Text = jsonData_loaded.textBox_pa_to_ml_min;
            textBox_time_reserve.Text = jsonData_loaded.textBox_time_reserve;


            numericUpDown_number.Value = jsonData_loaded.numericUpDown_number;
            textBox_experiment.Text = jsonData_loaded.textBox_experiment;
            numericUpDown_WP.Value = jsonData_loaded.numericUpDown_WP;
            numericUpDown_well.Value = jsonData_loaded.numericUpDown_well;
            numericUpDown_FOV.Value = jsonData_loaded.numericUpDown_FOV;
            textBox_cells.Text = jsonData_loaded.textBox_cells;
            textBox_well_position.Text = jsonData_loaded.textBox_well_position;
            maskedTextBox_date_seeded.Text = jsonData_loaded.maskedTextBox_date_seeded;
            textBox_note.Text = jsonData_loaded.textBox_note;


        }

        private void checkBox_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_2.Checked == true)
            {
                checkBox_1.Checked = false;
                checkBox_3.Checked = false;
                checkBox_4.Checked = false;
                update_2();
                button_start.Enabled = true;
                button_start_without_recording.Enabled = true;
            }

        }

        private void update_1()
        {
            float[] rates = Array.ConvertAll(textBox_rates1.Text.Trim().Split(','), s => float.Parse(s, enUS));
            float[] times = Array.ConvertAll(textBox_times1.Text.Trim().Split(','), s => float.Parse(s, enUS));
            float[] delays = Array.ConvertAll(textBox_delays1.Text.Trim().Split(','), s => float.Parse(s, enUS));

            req_time = times.Sum() + delays.Sum() + float.Parse(textBox_time_reserve.Text);

            float tmp_float = float.Parse(textBox_pa_to_ml_min.Text, enUS);

            float req_volume = 0;
            for (int i = 0; i < rates.Length & i < times.Length; i++)
            {
                req_volume = req_volume + (tmp_float * rates[i] * times[i]) / 60;
            }

            string rates_ml = "";
            for (int i = 0; i < rates.Length; i++)
            {
                rates_ml = rates_ml + (tmp_float * rates[i]).ToString("0.00", enUS) + ",";
            }
            rates_ml = rates_ml.Substring(0, rates_ml.Length - 1);


            string volumes_ml = "";
            for (int i = 0; i < rates.Length; i++)
            {
                volumes_ml = volumes_ml + (tmp_float * times[i] * rates[i] / 60).ToString("0.00", enUS) + ",";
            }
            volumes_ml = volumes_ml.Substring(0, volumes_ml.Length - 1);


            textBox_req_volume1.Text = req_volume.ToString("0.00");
            textBox_req_time1.Text = Math.Floor(req_time / 60).ToString("0") + "min " + (req_time % 60).ToString("0") + "s";
            
            actulaPump = numericUpDown_pump_mum1.Value.ToString("N0");

            serialPort2.WriteLine(actulaPump + " set units 0");
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set diameter " + textBox_diameter1.Text);
            Thread.Sleep(1000);
            //serialPort2.WriteLine(actulaPump + " set time " + textBox_times1.Text);
            serialPort2.WriteLine(actulaPump + " set volume " + volumes_ml);
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set rate " + rates_ml);
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set delay " + textBox_delays1.Text);

            header = "";
            header += "times " + textBox_times1.Text + "\n";
            header += "rates_ml/min " + rates_ml + "\n";
            header += "rates_Pa " + textBox_rates1.Text + "\n";
            header += "volumes " + volumes_ml + "\n";
            header += "delays " + textBox_delays1.Text + "\n";
        }
        private void update_2()
        {
            float[] rates = Array.ConvertAll(textBox_rates2.Text.Trim().Split(','), s => float.Parse(s, enUS));
            float[] times = Array.ConvertAll(textBox_times2.Text.Trim().Split(','), s => float.Parse(s, enUS));
            float[] delays = Array.ConvertAll(textBox_delays2.Text.Trim().Split(','), s => float.Parse(s, enUS));

            req_time = times.Sum() + delays.Sum() + float.Parse(textBox_time_reserve.Text);

            float tmp_float = float.Parse(textBox_pa_to_ml_min.Text, enUS);

            float req_volume = 0;
            for (int i = 0; i < rates.Length & i < times.Length; i++)
            {
                req_volume = req_volume + (tmp_float * rates[i] * times[i]) / 60;
            }

            string rates_ml = "";
            for (int i = 0; i < rates.Length; i++)
            {
                rates_ml = rates_ml + (tmp_float * rates[i]).ToString("0.00", enUS) + ",";
            }
            rates_ml = rates_ml.Substring(0, rates_ml.Length - 1);

            string volumes_ml = "";
            for (int i = 0; i < rates.Length; i++)
            {
                volumes_ml = volumes_ml + (tmp_float * times[i] * rates[i] / 60).ToString("0.00", enUS) + ",";
            }
            volumes_ml = volumes_ml.Substring(0, volumes_ml.Length - 1);


            textBox_req_volume2.Text = req_volume.ToString("0.00");
            textBox_req_time2.Text = Math.Floor(req_time / 60).ToString("0") + "min " + (req_time % 60).ToString("0") + "s";

            actulaPump = numericUpDown_pump_mum2.Value.ToString();

            serialPort2.WriteLine(actulaPump + " set units 0");
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set diameter " + textBox_diameter2.Text);
            Thread.Sleep(1000);
            //serialPort2.WriteLine(actulaPump + " set time " + textBox_times2.Text);
            serialPort2.WriteLine(actulaPump + " set volume " + volumes_ml);
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set rate " + rates_ml);
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set delay " + textBox_delays2.Text);


            header = "";
            header += "times " + textBox_times2.Text + "\n";
            header += "rates_ml/min " + rates_ml + "\n";
            header += "rates_Pa " + textBox_rates2.Text + "\n";
            header += "volumes " + volumes_ml + "\n";
            header += "delays " + textBox_delays2.Text + "\n";
        }



        private void uncheck_1(object sender, EventArgs e)
        {
            checkBox_1.Checked = false;
            textBox_req_volume1.Text = "";
            textBox_req_time1.Text = "";
        }

        private void uncheck_2(object sender, EventArgs e)
        {
            checkBox_2.Checked = false;
            textBox_req_volume2.Text = "";
            textBox_req_time2.Text = "";
        }

        private void unchecked_3(object sender, EventArgs e)
        {
            checkBox_3.Checked = false;
            textBox_req_volume3.Text = "";
            textBox_req_time3.Text = "";
        }

        private void uncheck_4(object sender, EventArgs e)
        {
            checkBox_4.Checked = false;
            textBox_req_volume4.Text = "";
            textBox_req_time4.Text = "";
        }

        private void checkBox_3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_3.Checked == true)
            {
                
                checkBox_2.Checked = false;
                checkBox_1.Checked = false;
                checkBox_4.Checked = false;
                update_3();
                button_start.Enabled = true;
                button_start_without_recording.Enabled = true;
            }
        }

        private void checkBox_4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_4.Checked == true)
            {
                checkBox_2.Checked = false;
                checkBox_3.Checked = false;
                checkBox_1.Checked = false;
                update_4();
                button_start.Enabled = true;
                button_start_without_recording.Enabled = true;
            }
        }

        private void update_3()
        {
            float[] rates = Array.ConvertAll(textBox_rates3.Text.Trim().Split(','), s => float.Parse(s, enUS));
            float[] times = Array.ConvertAll(textBox_times3.Text.Trim().Split(','), s => float.Parse(s, enUS));
            float[] delays = Array.ConvertAll(textBox_delays3.Text.Trim().Split(','), s => float.Parse(s, enUS));

            req_time = times.Sum() + delays.Sum() + float.Parse(textBox_time_reserve.Text);

            float tmp_float = float.Parse(textBox_pa_to_ml_min.Text, enUS);

            float req_volume = 0;
            for (int i = 0; i < rates.Length & i < times.Length; i++)
            {
                req_volume = req_volume + (tmp_float * rates[i] * times[i]) / 60;
            }

            string rates_ml = "";
            for (int i = 0; i < rates.Length; i++)
            {
                rates_ml = rates_ml + (tmp_float * rates[i]).ToString("0.00", enUS) + ",";
            }
            rates_ml = rates_ml.Substring(0, rates_ml.Length - 1);


            string volumes_ml = "";
            for (int i = 0; i < rates.Length; i++)
            {
                volumes_ml = volumes_ml + (tmp_float * times[i] * rates[i] / 60).ToString("0.00", enUS) + ",";
            }
            volumes_ml = volumes_ml.Substring(0, volumes_ml.Length - 1);

            textBox_req_volume3.Text = req_volume.ToString("0.00");
            textBox_req_time3.Text = Math.Floor(req_time / 60).ToString("0") + "min " + (req_time % 60).ToString("0") + "s";

            actulaPump = numericUpDown_pump_mum3.Value.ToString();

            serialPort2.WriteLine(actulaPump + " set units 0");
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set diameter " + textBox_diameter3.Text);
            Thread.Sleep(1000);
            //serialPort2.WriteLine(actulaPump + " set time " + textBox_times3.Text);
            serialPort2.WriteLine(actulaPump + " set volume " + volumes_ml);
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set rate " + rates_ml);
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set delay " + textBox_delays3.Text);



            header = "";
            header += "times " + textBox_times3.Text + "\n";
            header += "rates_ml/min " + rates_ml + "\n";
            header += "rates_Pa " + textBox_rates3.Text + "\n";
            header += "volumes " + volumes_ml + "\n";
            header += "delays " + textBox_delays3.Text + "\n";
        }
        private void update_4()
        {
            float[] rates = Array.ConvertAll(textBox_rates4.Text.Trim().Split(','), s => float.Parse(s));
            float[] times = Array.ConvertAll(textBox_times4.Text.Trim().Split(','), s => float.Parse(s));
            float[] delays = Array.ConvertAll(textBox_delays4.Text.Trim().Split(','), s => float.Parse(s));

            req_time = times.Sum() + delays.Sum() + float.Parse(textBox_time_reserve.Text);

            float tmp_float = float.Parse(textBox_pa_to_ml_min.Text, enUS);

            float req_volume = 0;
            for (int i = 0; i < rates.Length & i < times.Length; i++)
            {
                req_volume = req_volume + (tmp_float * rates[i] * times[i]) / 60;
            }

            string rates_ml = "";
            for (int i = 0; i < rates.Length; i++)
            {
                rates_ml = rates_ml + (tmp_float * rates[i]).ToString("0.00", enUS) + ",";
            }
            rates_ml = rates_ml.Substring(0, rates_ml.Length - 1);

            string volumes_ml = "";
            for (int i = 0; i < rates.Length; i++)
            {
                volumes_ml = volumes_ml + (tmp_float * times[i] * rates[i] / 60).ToString("0.00", enUS) + ",";
            }
            volumes_ml = volumes_ml.Substring(0, volumes_ml.Length - 1);


            textBox_req_volume4.Text = req_volume.ToString("0.00");
            textBox_req_time4.Text = Math.Floor(req_time / 60).ToString("0") + "min " + (req_time % 60).ToString("0") + "s";

            actulaPump = numericUpDown_pump_mum4.Value.ToString();

            serialPort2.WriteLine(actulaPump + " set units 0");
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set diameter " + textBox_diameter4.Text);
            Thread.Sleep(1000);
            //serialPort2.WriteLine(actulaPump + " set time " + textBox_times4.Text);
            serialPort2.WriteLine(actulaPump + " set volume " + volumes_ml);
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set rate " + rates_ml);
            Thread.Sleep(1000);
            serialPort2.WriteLine(actulaPump + " set delay " + textBox_delays4.Text);



            header = "";
            header += "times " + textBox_times4.Text + "\n";
            header += "rates_ml/min " + rates_ml + "\n";
            header += "rates_Pa " + textBox_rates4.Text + "\n";
            header += "volumes " + volumes_ml + "\n";
            header += "delays " + textBox_delays4.Text + "\n";
        }

        private void startTimer()
        {
            startTime = DateTime.Now;
            timer.Interval = 1000;
            timer.Tick -= new EventHandler(timer_Tick);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            UpdateText();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateText();
        }
        private void UpdateText()
        {
            TimeSpan diff = DateTime.Now.Subtract(startTime);
            label_timer.Text = diff.Minutes.ToString() + "min " + diff.Seconds.ToString() + "s" + " / " + Math.Floor(req_time / 60).ToString("0") + "min " + (req_time % 60).ToString("0") + "s";

           
            if ((diff.Minutes * 60 + diff.Seconds) > req_time)
            {
                if (button_stop.Enabled)
                {
                    Console.WriteLine("stop klick ");
                    button_stop.PerformClick();
                }
                if (button_stop_without_recording.Enabled)
                {
                    Console.WriteLine("stop click2");
                    button_stop_without_recording.PerformClick();
                }
            }


        }
        private void timer_stop()
        {
            timer.Stop();
            label_timer.Text = "timer";
        }

        private void numericUpDown_number_ValueChanged(object sender, EventArgs e)
        {
            update_filename();
        }

        private void update_filename()
        {
            string filename = "";
            filename += numericUpDown_number.Value.ToString("00");
            filename += "_" + textBox_experiment.Text;
            filename += "_WP" + numericUpDown_WP.Value.ToString("0");
            filename += "_well" + numericUpDown_well.Value.ToString("0");
            filename += "_FOV" + numericUpDown_FOV.Value.ToString("0");
            filename += "_" + textBox_cells.Text;

            textBox_filename.Text = filename;
        }

        private void textBox_experiment_TextChanged(object sender, EventArgs e)
        {
            update_filename();
        }

        private void textBox_cells_TextChanged(object sender, EventArgs e)
        {
            update_filename();
        }

        private void numericUpDown_WP_ValueChanged(object sender, EventArgs e)
        {
            update_filename();
        }

        private void numericUpDown_well_ValueChanged(object sender, EventArgs e)
        {
            update_filename();
        }

        private void numericUpDown_FOV_ValueChanged(object sender, EventArgs e)
        {
            update_filename();
        }

        private void textBox_well_position_TextChanged(object sender, EventArgs e)
        {
            update_filename();
        }

        private void maskedTextBox_date_seeded_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            update_filename();
        }

        private void textBox_note_TextChanged(object sender, EventArgs e)
        {
            update_filename();
        }


    }
}
