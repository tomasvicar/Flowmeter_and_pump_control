using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Flowmeter_and_pump
{
    public partial class FormSequence : MetroForm
    {
        Form1 form;
        MetroLabel label_name;
        MetroLabel labele_value;
        private CultureInfo enUS = new CultureInfo("en-US");
        private double req_time;
        public FormSequence(Form1 form, List<MetroLabel> label_list_names, List<MetroLabel> label_list_values, object sender)
        {
            this.form = form;
            InitializeComponent();

            for (int i = 0; i < label_list_names.Count; i++)
            {
                if ((label_list_names[i] == sender) | (label_list_values[i] == sender))
                {
                    label_name = label_list_names[i];
                    texBox_name.Text = label_name.Text;
                    labele_value = label_list_values[i];
                    decodeValue(labele_value.Text);
                    break;
                }
            }

        }

        private void FormSequence_Load(object sender, EventArgs e)
        {



        }

        private void decodeValue(string value)
        {
            var values = value.Split(new string[] { "    " }, StringSplitOptions.None);
            textBox_sequence.Text = values[0];

            try
            {
                numericUpDown_number.Value = Decimal.Parse(values[3].Replace("pump ", ""));
            }
            catch (FormatException e)
            {
                numericUpDown_number.Value = 1m;
            }


        }

        private void encodeValues()
        {
            label_name.Text = texBox_name.Text;
 
            string result = "";
            result += textBox_sequence.Text;
            result += "    ";
            result += get_ml();
            result += "    ";
            result += get_time();
            result += "    ";
            result += "pump " + numericUpDown_number.Value.ToString();

            labele_value.Text = result;

        }

        private string get_ml()
        {

            Tuple<List<double>, List<double>, List<double>> values = split_sequence(textBox_sequence.Text);
            List<double> delays = values.Item1;
            List<double> times = values.Item2;
            List<double> pascals = values.Item3;


            double req_volume = 0;
            for (int i = 0; i < pascals.Count; i++)
            {
                req_volume = req_volume + (float.Parse(form.textBox_pa_is_xx_ml_min.Text, enUS) * pascals[i] * times[i]) / 60;
            }
            
            return req_volume.ToString("0.00") + "ml";
        }
        private string get_time()
        {
            Tuple<List<double>, List<double>, List<double>> values = split_sequence(textBox_sequence.Text);
            List<double> delays = values.Item1;
            List<double> times = values.Item2;
            List<double> pascals = values.Item3;

            req_time = times.Sum() + delays.Sum() + float.Parse(form.textBox_time_reserve_s.Text, enUS);

            return Math.Floor(req_time / 60).ToString("0") + "min " + (req_time % 60).ToString("0") + "s";
        }

        public static Tuple<List<double>, List<double>, List<double>> split_sequence(string sequance)
        {
            CultureInfo enUS = new CultureInfo("en-US");
            var pulses = sequance.Split(new string[] { "|" }, StringSplitOptions.None);

            List<double> delays = new List<double>();
            List<double> times = new List<double>();
            List<double> pascals = new List<double>();
            foreach (string pulse in pulses)
            { 
                string[] values = pulse.Split(new string[] { ",","-" }, StringSplitOptions.None);
                delays.Add(double.Parse(values[0], enUS));
                times.Add(double.Parse(values[1], enUS));
                pascals.Add(double.Parse(values[2], enUS));
            }

            return Tuple.Create(delays, times, pascals);
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            encodeValues();
            form.req_time = (float)req_time;
            this.Close();
        }
    }
}
