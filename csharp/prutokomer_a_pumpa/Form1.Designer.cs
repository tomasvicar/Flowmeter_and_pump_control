
namespace prutokomer_a_pumpa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_COM_flow = new System.Windows.Forms.Label();
            this.chart_flow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.checkBox_showPlot = new System.Windows.Forms.CheckBox();
            this.label_COM_pump = new System.Windows.Forms.Label();
            this.listBox_pump_comunication = new System.Windows.Forms.ListBox();
            this.button_start_without_recording = new System.Windows.Forms.Button();
            this.button_stop_without_recording = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_times1 = new System.Windows.Forms.TextBox();
            this.label_time1 = new System.Windows.Forms.Label();
            this.textBox_rates1 = new System.Windows.Forms.TextBox();
            this.label_rate1 = new System.Windows.Forms.Label();
            this.textBox_delays1 = new System.Windows.Forms.TextBox();
            this.label_delay1 = new System.Windows.Forms.Label();
            this.label_diameter1 = new System.Windows.Forms.Label();
            this.textBox_diameter1 = new System.Windows.Forms.TextBox();
            this.numericUpDown_pump_mum1 = new System.Windows.Forms.NumericUpDown();
            this.label_pump_num1 = new System.Windows.Forms.Label();
            this.label_required_time1 = new System.Windows.Forms.Label();
            this.textBox_req_time1 = new System.Windows.Forms.TextBox();
            this.label_req_volume1 = new System.Windows.Forms.Label();
            this.label_pa_to_ml_min = new System.Windows.Forms.Label();
            this.label_pa_to_ml_min2 = new System.Windows.Forms.Label();
            this.textBox_pa_to_ml_min = new System.Windows.Forms.TextBox();
            this.checkBox_1 = new System.Windows.Forms.CheckBox();
            this.textBox_req_volume1 = new System.Windows.Forms.TextBox();
            this.button_save_settings = new System.Windows.Forms.Button();
            this.button_load_setttings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_flow)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pump_mum1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_COM_flow
            // 
            this.label_COM_flow.AutoSize = true;
            this.label_COM_flow.ForeColor = System.Drawing.Color.Red;
            this.label_COM_flow.Location = new System.Drawing.Point(329, 7);
            this.label_COM_flow.Name = "label_COM_flow";
            this.label_COM_flow.Size = new System.Drawing.Size(20, 17);
            this.label_COM_flow.TabIndex = 0;
            this.label_COM_flow.Text = "NA";
            this.label_COM_flow.UseCompatibleTextRendering = true;
            this.label_COM_flow.Click += new System.EventHandler(this.COM_flow_Click);
            // 
            // chart_flow
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_flow.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_flow.Legends.Add(legend2);
            this.chart_flow.Location = new System.Drawing.Point(12, 29);
            this.chart_flow.Name = "chart_flow";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_flow.Series.Add(series2);
            this.chart_flow.Size = new System.Drawing.Size(1255, 301);
            this.chart_flow.TabIndex = 1;
            this.chart_flow.Text = "flow";
            // 
            // textBox_filename
            // 
            this.textBox_filename.Location = new System.Drawing.Point(318, 336);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(221, 20);
            this.textBox_filename.TabIndex = 2;
            this.textBox_filename.Text = "filename";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(545, 336);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(131, 49);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(682, 345);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(98, 31);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // checkBox_showPlot
            // 
            this.checkBox_showPlot.AutoSize = true;
            this.checkBox_showPlot.Location = new System.Drawing.Point(458, 6);
            this.checkBox_showPlot.Name = "checkBox_showPlot";
            this.checkBox_showPlot.Size = new System.Drawing.Size(71, 17);
            this.checkBox_showPlot.TabIndex = 5;
            this.checkBox_showPlot.Text = "show plot";
            this.checkBox_showPlot.UseVisualStyleBackColor = true;
            this.checkBox_showPlot.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_COM_pump
            // 
            this.label_COM_pump.AutoSize = true;
            this.label_COM_pump.ForeColor = System.Drawing.Color.Red;
            this.label_COM_pump.Location = new System.Drawing.Point(1099, 343);
            this.label_COM_pump.Name = "label_COM_pump";
            this.label_COM_pump.Size = new System.Drawing.Size(20, 17);
            this.label_COM_pump.TabIndex = 6;
            this.label_COM_pump.Text = "NA";
            this.label_COM_pump.UseCompatibleTextRendering = true;
            this.label_COM_pump.Click += new System.EventHandler(this.label_COM_pump_Click);
            // 
            // listBox_pump_comunication
            // 
            this.listBox_pump_comunication.FormattingEnabled = true;
            this.listBox_pump_comunication.Location = new System.Drawing.Point(825, 380);
            this.listBox_pump_comunication.Name = "listBox_pump_comunication";
            this.listBox_pump_comunication.Size = new System.Drawing.Size(451, 121);
            this.listBox_pump_comunication.TabIndex = 7;
            // 
            // button_start_without_recording
            // 
            this.button_start_without_recording.Location = new System.Drawing.Point(870, 336);
            this.button_start_without_recording.Name = "button_start_without_recording";
            this.button_start_without_recording.Size = new System.Drawing.Size(101, 27);
            this.button_start_without_recording.TabIndex = 8;
            this.button_start_without_recording.Text = "Start w/o rec.";
            this.button_start_without_recording.UseVisualStyleBackColor = true;
            this.button_start_without_recording.Click += new System.EventHandler(this.button_start_without_recording_Click);
            // 
            // button_stop_without_recording
            // 
            this.button_stop_without_recording.Location = new System.Drawing.Point(992, 336);
            this.button_stop_without_recording.Name = "button_stop_without_recording";
            this.button_stop_without_recording.Size = new System.Drawing.Size(101, 27);
            this.button_stop_without_recording.TabIndex = 9;
            this.button_stop_without_recording.Text = "Stop w/o rec.";
            this.button_stop_without_recording.UseVisualStyleBackColor = true;
            this.button_stop_without_recording.Click += new System.EventHandler(this.button_stop_without_recording_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_req_volume1);
            this.panel1.Controls.Add(this.checkBox_1);
            this.panel1.Controls.Add(this.label_req_volume1);
            this.panel1.Controls.Add(this.textBox_req_time1);
            this.panel1.Controls.Add(this.label_required_time1);
            this.panel1.Controls.Add(this.label_pump_num1);
            this.panel1.Controls.Add(this.numericUpDown_pump_mum1);
            this.panel1.Controls.Add(this.textBox_diameter1);
            this.panel1.Controls.Add(this.label_diameter1);
            this.panel1.Controls.Add(this.textBox_delays1);
            this.panel1.Controls.Add(this.label_delay1);
            this.panel1.Controls.Add(this.textBox_times1);
            this.panel1.Controls.Add(this.label_time1);
            this.panel1.Controls.Add(this.textBox_rates1);
            this.panel1.Controls.Add(this.label_rate1);
            this.panel1.Location = new System.Drawing.Point(14, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 118);
            this.panel1.TabIndex = 10;
            // 
            // textBox_times1
            // 
            this.textBox_times1.Location = new System.Drawing.Point(83, 30);
            this.textBox_times1.Name = "textBox_times1";
            this.textBox_times1.Size = new System.Drawing.Size(269, 20);
            this.textBox_times1.TabIndex = 3;
            this.textBox_times1.Text = "1 2 3";
            // 
            // label_time1
            // 
            this.label_time1.AutoSize = true;
            this.label_time1.Location = new System.Drawing.Point(7, 33);
            this.label_time1.Name = "label_time1";
            this.label_time1.Size = new System.Drawing.Size(45, 13);
            this.label_time1.TabIndex = 2;
            this.label_time1.Text = "times (s)";
            // 
            // textBox_rates1
            // 
            this.textBox_rates1.Location = new System.Drawing.Point(83, 4);
            this.textBox_rates1.Name = "textBox_rates1";
            this.textBox_rates1.Size = new System.Drawing.Size(269, 20);
            this.textBox_rates1.TabIndex = 1;
            this.textBox_rates1.Text = "1 2 3";
            // 
            // label_rate1
            // 
            this.label_rate1.AutoSize = true;
            this.label_rate1.Location = new System.Drawing.Point(7, 7);
            this.label_rate1.Name = "label_rate1";
            this.label_rate1.Size = new System.Drawing.Size(52, 13);
            this.label_rate1.TabIndex = 0;
            this.label_rate1.Text = "rates (Pa)";
            // 
            // textBox_delays1
            // 
            this.textBox_delays1.Location = new System.Drawing.Point(83, 56);
            this.textBox_delays1.Name = "textBox_delays1";
            this.textBox_delays1.Size = new System.Drawing.Size(269, 20);
            this.textBox_delays1.TabIndex = 12;
            this.textBox_delays1.Text = "1 2 3";
            // 
            // label_delay1
            // 
            this.label_delay1.AutoSize = true;
            this.label_delay1.Location = new System.Drawing.Point(7, 59);
            this.label_delay1.Name = "label_delay1";
            this.label_delay1.Size = new System.Drawing.Size(51, 13);
            this.label_delay1.TabIndex = 11;
            this.label_delay1.Text = "delays (s)";
            // 
            // label_diameter1
            // 
            this.label_diameter1.AutoSize = true;
            this.label_diameter1.Location = new System.Drawing.Point(7, 79);
            this.label_diameter1.Name = "label_diameter1";
            this.label_diameter1.Size = new System.Drawing.Size(72, 13);
            this.label_diameter1.TabIndex = 13;
            this.label_diameter1.Text = "diameter (mm)";
            // 
            // textBox_diameter1
            // 
            this.textBox_diameter1.Location = new System.Drawing.Point(21, 91);
            this.textBox_diameter1.Name = "textBox_diameter1";
            this.textBox_diameter1.Size = new System.Drawing.Size(34, 20);
            this.textBox_diameter1.TabIndex = 14;
            this.textBox_diameter1.Text = "19";
            // 
            // numericUpDown_pump_mum1
            // 
            this.numericUpDown_pump_mum1.Location = new System.Drawing.Point(97, 92);
            this.numericUpDown_pump_mum1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_pump_mum1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_pump_mum1.Name = "numericUpDown_pump_mum1";
            this.numericUpDown_pump_mum1.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown_pump_mum1.TabIndex = 15;
            this.numericUpDown_pump_mum1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_pump_num1
            // 
            this.label_pump_num1.AutoSize = true;
            this.label_pump_num1.Location = new System.Drawing.Point(85, 79);
            this.label_pump_num1.Name = "label_pump_num1";
            this.label_pump_num1.Size = new System.Drawing.Size(56, 13);
            this.label_pump_num1.TabIndex = 16;
            this.label_pump_num1.Text = "pump num";
            // 
            // label_required_time1
            // 
            this.label_required_time1.AutoSize = true;
            this.label_required_time1.Location = new System.Drawing.Point(151, 79);
            this.label_required_time1.Name = "label_required_time1";
            this.label_required_time1.Size = new System.Drawing.Size(61, 13);
            this.label_required_time1.TabIndex = 17;
            this.label_required_time1.Text = "req. time (s)";
            // 
            // textBox_req_time1
            // 
            this.textBox_req_time1.Location = new System.Drawing.Point(159, 94);
            this.textBox_req_time1.Name = "textBox_req_time1";
            this.textBox_req_time1.ReadOnly = true;
            this.textBox_req_time1.Size = new System.Drawing.Size(40, 20);
            this.textBox_req_time1.TabIndex = 18;
            // 
            // label_req_volume1
            // 
            this.label_req_volume1.AutoSize = true;
            this.label_req_volume1.Location = new System.Drawing.Point(227, 81);
            this.label_req_volume1.Name = "label_req_volume1";
            this.label_req_volume1.Size = new System.Drawing.Size(81, 13);
            this.label_req_volume1.TabIndex = 18;
            this.label_req_volume1.Text = "req. volume (ml)";
            // 
            // label_pa_to_ml_min
            // 
            this.label_pa_to_ml_min.AutoSize = true;
            this.label_pa_to_ml_min.Location = new System.Drawing.Point(14, 336);
            this.label_pa_to_ml_min.Name = "label_pa_to_ml_min";
            this.label_pa_to_ml_min.Size = new System.Drawing.Size(33, 13);
            this.label_pa_to_ml_min.TabIndex = 11;
            this.label_pa_to_ml_min.Text = "Pa is:";
            // 
            // label_pa_to_ml_min2
            // 
            this.label_pa_to_ml_min2.AutoSize = true;
            this.label_pa_to_ml_min2.Location = new System.Drawing.Point(91, 336);
            this.label_pa_to_ml_min2.Name = "label_pa_to_ml_min2";
            this.label_pa_to_ml_min2.Size = new System.Drawing.Size(38, 13);
            this.label_pa_to_ml_min2.TabIndex = 12;
            this.label_pa_to_ml_min2.Text = "ml/min";
            // 
            // textBox_pa_to_ml_min
            // 
            this.textBox_pa_to_ml_min.Location = new System.Drawing.Point(48, 333);
            this.textBox_pa_to_ml_min.Name = "textBox_pa_to_ml_min";
            this.textBox_pa_to_ml_min.Size = new System.Drawing.Size(45, 20);
            this.textBox_pa_to_ml_min.TabIndex = 15;
            this.textBox_pa_to_ml_min.Text = "12.98";
            // 
            // checkBox_1
            // 
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.Location = new System.Drawing.Point(320, 94);
            this.checkBox_1.Name = "checkBox_1";
            this.checkBox_1.Size = new System.Drawing.Size(15, 14);
            this.checkBox_1.TabIndex = 19;
            this.checkBox_1.UseVisualStyleBackColor = true;
            this.checkBox_1.CheckedChanged += new System.EventHandler(this.checkBox_1_CheckedChanged);
            // 
            // textBox_req_volume1
            // 
            this.textBox_req_volume1.Location = new System.Drawing.Point(242, 95);
            this.textBox_req_volume1.Name = "textBox_req_volume1";
            this.textBox_req_volume1.ReadOnly = true;
            this.textBox_req_volume1.Size = new System.Drawing.Size(40, 20);
            this.textBox_req_volume1.TabIndex = 19;
            // 
            // button_save_settings
            // 
            this.button_save_settings.Location = new System.Drawing.Point(1167, 336);
            this.button_save_settings.Name = "button_save_settings";
            this.button_save_settings.Size = new System.Drawing.Size(109, 20);
            this.button_save_settings.TabIndex = 16;
            this.button_save_settings.Text = "save settings";
            this.button_save_settings.UseVisualStyleBackColor = true;
            this.button_save_settings.Click += new System.EventHandler(this.button_save_settings_Click);
            // 
            // button_load_setttings
            // 
            this.button_load_setttings.Location = new System.Drawing.Point(1167, 356);
            this.button_load_setttings.Name = "button_load_setttings";
            this.button_load_setttings.Size = new System.Drawing.Size(109, 20);
            this.button_load_setttings.TabIndex = 17;
            this.button_load_setttings.Text = "load settings";
            this.button_load_setttings.UseVisualStyleBackColor = true;
            this.button_load_setttings.Click += new System.EventHandler(this.button_load_setttings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 631);
            this.Controls.Add(this.button_load_setttings);
            this.Controls.Add(this.button_save_settings);
            this.Controls.Add(this.textBox_pa_to_ml_min);
            this.Controls.Add(this.label_pa_to_ml_min2);
            this.Controls.Add(this.label_pa_to_ml_min);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_stop_without_recording);
            this.Controls.Add(this.button_start_without_recording);
            this.Controls.Add(this.listBox_pump_comunication);
            this.Controls.Add(this.label_COM_pump);
            this.Controls.Add(this.checkBox_showPlot);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_filename);
            this.Controls.Add(this.chart_flow);
            this.Controls.Add(this.label_COM_flow);
            this.Name = "Form1";
            this.Text = "Flowmeter and pump";
            ((System.ComponentModel.ISupportInitialize)(this.chart_flow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pump_mum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_COM_flow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_flow;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.CheckBox checkBox_showPlot;
        private System.Windows.Forms.Label label_COM_pump;
        private System.Windows.Forms.ListBox listBox_pump_comunication;
        private System.Windows.Forms.Button button_start_without_recording;
        private System.Windows.Forms.Button button_stop_without_recording;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_times1;
        private System.Windows.Forms.Label label_time1;
        private System.Windows.Forms.TextBox textBox_rates1;
        private System.Windows.Forms.Label label_rate1;
        private System.Windows.Forms.Label label_required_time1;
        private System.Windows.Forms.Label label_pump_num1;
        private System.Windows.Forms.NumericUpDown numericUpDown_pump_mum1;
        private System.Windows.Forms.TextBox textBox_diameter1;
        private System.Windows.Forms.Label label_diameter1;
        private System.Windows.Forms.TextBox textBox_delays1;
        private System.Windows.Forms.Label label_delay1;
        private System.Windows.Forms.TextBox textBox_req_volume1;
        private System.Windows.Forms.CheckBox checkBox_1;
        private System.Windows.Forms.Label label_req_volume1;
        private System.Windows.Forms.TextBox textBox_req_time1;
        private System.Windows.Forms.Label label_pa_to_ml_min;
        private System.Windows.Forms.Label label_pa_to_ml_min2;
        private System.Windows.Forms.TextBox textBox_pa_to_ml_min;
        private System.Windows.Forms.Button button_save_settings;
        private System.Windows.Forms.Button button_load_setttings;
    }
}

