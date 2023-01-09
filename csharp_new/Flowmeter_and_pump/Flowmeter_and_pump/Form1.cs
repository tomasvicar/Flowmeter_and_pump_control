using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;

namespace Flowmeter_and_pump
{
    public partial class Form1 : MetroForm
    {
        private Logger logger;
        public float req_time;
        private Flowmeter flowmeter;
        private Pump pump;
        private Timer timer;
        private Saver saver;
        private List<MetroLabel> label_list_names = new List<MetroLabel>();
        private List<MetroLabel> label_list_values = new List<MetroLabel>();
        private List<MetroCheckBox> label_list_checkboxes = new List<MetroCheckBox>();
        private List<MetroPanel> panel_list = new List<MetroPanel>();
        public string header;
        private CultureInfo enUS = new CultureInfo("en-US");

        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = enUS;
            InitializeComponent();
            logger = new Logger();

            flowmeter = new Flowmeter(this);
            flowmeter.openFlowSerial();


            pump = new Pump(this);
            pump.openPumpSerial();

            saver = new Saver(this);
            saver.get_objects_to_save();

            fillLists();
            numericUpDown_num_of_seq_ValueChanged(null, EventArgs.Empty);
            textBox_note_TextChanged(null, EventArgs.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_COM_flow_Click(object sender, EventArgs e)
        {
            flowmeter.openFlowSerial();
        }

        private void label_COM_pump_Click(object sender, EventArgs e)
        {
            pump.openPumpSerial();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            foreach (var series in chart_flow.Series)
            {
                series.Points.Clear();
            }
            checkBox_show_plot.Checked = true;

            button_start.Enabled = false;
            button_start_without_recording.Enabled = false;
            textBox_filename.Enabled = false;

            flowmeter.startTextFile();

            pump.run();
            timer = new Timer(this);
            timer.startTimer();


            button_stop.Enabled = true;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            button_stop.Enabled = false;
            textBox_filename.Enabled = true;

            flowmeter.recording = false;
            flowmeter.closeTextfile();

            pump.stop();

            timer.stop();

            button_start.Enabled = true;
            button_start_without_recording.Enabled = true;
        }

        private void button_start_without_recording_Click(object sender, EventArgs e)
        {
            button_start_without_recording.Enabled = false;
            button_start.Enabled = false;

            pump.run();
            timer = new Timer(this);
            timer.startTimer();

            button_stop_without_recording.Enabled = true;
        }

        private void button_stop_without_recording_Click(object sender, EventArgs e)
        {
            button_stop_without_recording.Enabled = false;

            pump.stop();
            timer.stop();

            button_start_without_recording.Enabled = true;
            button_start.Enabled = true;
        }

        private void label_sequence_Click(object sender, EventArgs e)
        {
            FormSequence formSequnece = new FormSequence(this, label_list_names, label_list_values, sender);
            formSequnece.ShowDialog();
        }

        private void fillLists()
        {

            label_list_names.Add(this.label_sequence_name1);
            label_list_names.Add(this.label_sequence_name2);
            label_list_names.Add(this.label_sequence_name3);
            label_list_names.Add(this.label_sequence_name4);
            label_list_names.Add(this.label_sequence_name5);
            label_list_names.Add(this.label_sequence_name6);
            label_list_names.Add(this.label_sequence_name7);

            label_list_values.Add(this.label_sequence1);
            label_list_values.Add(this.label_sequence2);
            label_list_values.Add(this.label_sequence3);
            label_list_values.Add(this.label_sequence4);
            label_list_values.Add(this.label_sequence5);
            label_list_values.Add(this.label_sequence6);
            label_list_values.Add(this.label_sequence7);

            label_list_checkboxes.Add(this.checkBox_sequence1);
            label_list_checkboxes.Add(this.checkBox_sequence2);
            label_list_checkboxes.Add(this.checkBox_sequence3);
            label_list_checkboxes.Add(this.checkBox_sequence4);
            label_list_checkboxes.Add(this.checkBox_sequence5);
            label_list_checkboxes.Add(this.checkBox_sequence6);
            label_list_checkboxes.Add(this.checkBox_sequence7);


            panel_list.Add(this.panel_pump_panel1);
            panel_list.Add(this.panel_pump_panel2);
            panel_list.Add(this.panel_pump_panel3);
            panel_list.Add(this.panel_pump_panel4);
            panel_list.Add(this.panel_pump_panel5);
            panel_list.Add(this.panel_pump_panel6);
            panel_list.Add(this.panel_pump_panel7);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saver.save();
        }

        private void loadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saver.load();
        }

        private void numericUpDown_num_of_seq_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < panel_list.Count; i++)
            {
                panel_list[i].Visible = (i < numericUpDown_num_of_seq.Value);
            }
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings(this);
            formSettings.ShowDialog();
        }

        private void checkBox_sequence1_CheckedChanged(object sender, EventArgs e)
        {
            MetroCheckBox sender_converted = (MetroCheckBox)Convert.ChangeType(sender, typeof(MetroCheckBox));
            if (sender_converted.Checked == true)
            {
                foreach (MetroCheckBox cb in label_list_checkboxes)
                {
                    cb.Enabled = false;
                }
                sender_converted.Enabled = true;

                header = pump.activateSequence(label_list_names, label_list_values, label_list_checkboxes, sender_converted);

                button_start.Enabled = true;
                button_start_without_recording.Enabled = true;
            }
            else 
            {
                foreach (MetroCheckBox cb in label_list_checkboxes)
                {
                    cb.Enabled = true;
                }
                button_start.Enabled = false;
                button_start_without_recording.Enabled = false;
            }

        }

        private void textBox_note_TextChanged(object sender, EventArgs e)
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

        private void button_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_filename.Text);
        }

        private void checkBox_show_plot_CheckedChanged(object sender, EventArgs e)
        {
            MetroCheckBox sender_converted = (MetroCheckBox)Convert.ChangeType(sender, typeof(MetroCheckBox));
            if (sender_converted.Checked)
            {
                foreach (var series in chart_flow.Series)
                {
                    series.Points.Clear();
                }
                //chart_flow.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                //chart_flow.ChartAreas[0].CursorX.AutoScroll = true;
                //chart_flow.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

                //chart_flow.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                //chart_flow.ChartAreas[0].AxisY2.ScaleView.Zoomable = true;
                //chart_flow.ChartAreas[0].CursorY.AutoScroll = true;
                //chart_flow.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            }
            
        }

        private void plotFlowFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlotFlowFile formPlotFlowFile = new FormPlotFlowFile();
            formPlotFlowFile.Show();
        }
    }
}
