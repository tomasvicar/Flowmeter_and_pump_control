using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowmeter_and_pump
{
    public partial class FormPlotFlowFile : Form
    {
        List<float> times = new List<float>();
        List<float> values = new List<float>();
        public FormPlotFlowFile()
        {
            InitializeComponent();
        }

        private void FormPlotFlowFile_Load(object sender, EventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            myOpenFileDialog.FileName = "flow_file.txt";
            myOpenFileDialog.InitialDirectory = ".";
            myOpenFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (!(myOpenFileDialog.ShowDialog() == DialogResult.OK))
            {
                this.Close();
            }

            load_file(myOpenFileDialog);




            
        }

        private void load_file(OpenFileDialog myOpenFileDialog)
        {
            string[] lines = System.IO.File.ReadAllLines(myOpenFileDialog.FileName);

            bool is_header = true;
            foreach (string line in lines)
            {
                if (line == "###header_end###")
                {
                    is_header = false;
                    continue;
                }
                if (is_header)
                {
                    listBox_header.BeginUpdate();
                    listBox_header.Items.Add(line);
                    listBox_header.EndUpdate();
                }
                else 
                {
                    string[] time_value = line.Split(';');

                    var tmp = time_value[0].Split(':');
                    var time = float.Parse(tmp[0], CultureInfo.InvariantCulture) * 3600
                        + float.Parse(tmp[1], CultureInfo.InvariantCulture) * 60
                        + float.Parse(tmp[2], CultureInfo.InvariantCulture);

                    times.Add(time);
                    values.Add(float.Parse(time_value[1], CultureInfo.InvariantCulture));
                }
            }
            float time0 = times[0];
            for (int i = 0; i < times.Count; i++)
            {
                chart_flow.Series[0].Points.AddXY(times[i] - time0, values[i]);
            }
            chart_flow.ChartAreas[0].RecalculateAxesScale();
            chart_flow.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart_flow.ChartAreas[0].CursorX.AutoScroll = true;
            chart_flow.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            chart_flow.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart_flow.ChartAreas[0].AxisY2.ScaleView.Zoomable = true;
            chart_flow.ChartAreas[0].CursorY.AutoScroll = true;
            chart_flow.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
