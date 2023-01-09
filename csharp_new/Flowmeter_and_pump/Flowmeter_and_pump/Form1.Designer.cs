
namespace Flowmeter_and_pump
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_start = new MetroFramework.Controls.MetroButton();
            this.chart_flow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_stop = new MetroFramework.Controls.MetroButton();
            this.button_start_without_recording = new MetroFramework.Controls.MetroButton();
            this.button_stop_without_recording = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotFlowFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_pump_panel1 = new MetroFramework.Controls.MetroPanel();
            this.checkBox_sequence1 = new MetroFramework.Controls.MetroCheckBox();
            this.label_sequence_name1 = new MetroFramework.Controls.MetroLabel();
            this.label_sequence1 = new MetroFramework.Controls.MetroLabel();
            this.panel_data_description = new MetroFramework.Controls.MetroPanel();
            this.button_copy = new MetroFramework.Controls.MetroButton();
            this.listBox_pump_comunication = new System.Windows.Forms.ListBox();
            this.textBox_note = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.maskedTextBox_date_seeded = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown_well_position = new FlatNumericUpDown();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.textBox_cells = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.textBox_experiment = new MetroFramework.Controls.MetroTextBox();
            this.numericUpDown_FOV = new FlatNumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown_well = new FlatNumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown_WP = new FlatNumericUpDown();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox_filename = new MetroFramework.Controls.MetroTextBox();
            this.numericUpDown_number = new FlatNumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel_pump_panel2 = new MetroFramework.Controls.MetroPanel();
            this.checkBox_sequence2 = new MetroFramework.Controls.MetroCheckBox();
            this.label_sequence_name2 = new MetroFramework.Controls.MetroLabel();
            this.label_sequence2 = new MetroFramework.Controls.MetroLabel();
            this.panel_pump_panel3 = new MetroFramework.Controls.MetroPanel();
            this.checkBox_sequence3 = new MetroFramework.Controls.MetroCheckBox();
            this.label_sequence_name3 = new MetroFramework.Controls.MetroLabel();
            this.label_sequence3 = new MetroFramework.Controls.MetroLabel();
            this.panel_pump_panel4 = new MetroFramework.Controls.MetroPanel();
            this.checkBox_sequence4 = new MetroFramework.Controls.MetroCheckBox();
            this.label_sequence_name4 = new MetroFramework.Controls.MetroLabel();
            this.label_sequence4 = new MetroFramework.Controls.MetroLabel();
            this.panel_pump_panel5 = new MetroFramework.Controls.MetroPanel();
            this.checkBox_sequence5 = new MetroFramework.Controls.MetroCheckBox();
            this.label_sequence_name5 = new MetroFramework.Controls.MetroLabel();
            this.label_sequence5 = new MetroFramework.Controls.MetroLabel();
            this.panel_pump_panel6 = new MetroFramework.Controls.MetroPanel();
            this.checkBox_sequence6 = new MetroFramework.Controls.MetroCheckBox();
            this.label_sequence_name6 = new MetroFramework.Controls.MetroLabel();
            this.label_sequence6 = new MetroFramework.Controls.MetroLabel();
            this.panel_pump_panel7 = new MetroFramework.Controls.MetroPanel();
            this.checkBox_sequence7 = new MetroFramework.Controls.MetroCheckBox();
            this.label_sequence_name7 = new MetroFramework.Controls.MetroLabel();
            this.label_sequence7 = new MetroFramework.Controls.MetroLabel();
            this.label_COM_flow = new MetroFramework.Controls.MetroLabel();
            this.checkBox_show_plot = new MetroFramework.Controls.MetroCheckBox();
            this.label_COM_pump = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.label_timer = new MetroFramework.Controls.MetroLabel();
            this.textBox_pa_is_xx_ml_min = new MetroFramework.Controls.MetroTextBox();
            this.textBox_time_reserve_s = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.textBox_diameter = new MetroFramework.Controls.MetroTextBox();
            this.numericUpDown_num_of_seq = new FlatNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart_flow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel_pump_panel1.SuspendLayout();
            this.panel_data_description.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_well_position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_well)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number)).BeginInit();
            this.panel_pump_panel2.SuspendLayout();
            this.panel_pump_panel3.SuspendLayout();
            this.panel_pump_panel4.SuspendLayout();
            this.panel_pump_panel5.SuspendLayout();
            this.panel_pump_panel6.SuspendLayout();
            this.panel_pump_panel7.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_num_of_seq)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.button_start.Location = new System.Drawing.Point(761, 684);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(76, 25);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "start";
            this.button_start.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_start.UseSelectable = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // chart_flow
            // 
            this.chart_flow.BackColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.LabelStyle.Format = "#.0";
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea3.BackColor = System.Drawing.Color.Gray;
            chartArea3.Name = "ChartArea1";
            this.chart_flow.ChartAreas.Add(chartArea3);
            this.chart_flow.Location = new System.Drawing.Point(7, 32);
            this.chart_flow.Name = "chart_flow";
            series3.BackSecondaryColor = System.Drawing.Color.White;
            series3.BorderColor = System.Drawing.Color.White;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.DarkBlue;
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.chart_flow.Series.Add(series3);
            this.chart_flow.Size = new System.Drawing.Size(1278, 402);
            this.chart_flow.TabIndex = 1;
            this.chart_flow.Text = "chart1";
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.button_stop.Location = new System.Drawing.Point(843, 684);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(76, 25);
            this.button_stop.TabIndex = 2;
            this.button_stop.Text = "stop";
            this.button_stop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_stop.UseSelectable = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start_without_recording
            // 
            this.button_start_without_recording.Enabled = false;
            this.button_start_without_recording.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.button_start_without_recording.Location = new System.Drawing.Point(1087, 684);
            this.button_start_without_recording.Name = "button_start_without_recording";
            this.button_start_without_recording.Size = new System.Drawing.Size(93, 25);
            this.button_start_without_recording.TabIndex = 3;
            this.button_start_without_recording.Text = "start w/o rec.";
            this.button_start_without_recording.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_start_without_recording.UseSelectable = true;
            this.button_start_without_recording.Click += new System.EventHandler(this.button_start_without_recording_Click);
            // 
            // button_stop_without_recording
            // 
            this.button_stop_without_recording.Enabled = false;
            this.button_stop_without_recording.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.button_stop_without_recording.Location = new System.Drawing.Point(1185, 684);
            this.button_stop_without_recording.Name = "button_stop_without_recording";
            this.button_stop_without_recording.Size = new System.Drawing.Size(94, 25);
            this.button_stop_without_recording.TabIndex = 4;
            this.button_stop_without_recording.Text = "stop w/o rec.";
            this.button_stop_without_recording.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_stop_without_recording.UseSelectable = true;
            this.button_stop_without_recording.Click += new System.EventHandler(this.button_stop_without_recording_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(174, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadSettingsToolStripMenuItem});
            this.controlToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.saveToolStripMenuItem.Text = "Save settings";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadSettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.loadSettingsToolStripMenuItem.Text = "Load settings";
            this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.loadSettingsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plotFlowFileToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // plotFlowFileToolStripMenuItem
            // 
            this.plotFlowFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plotFlowFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.plotFlowFileToolStripMenuItem.Name = "plotFlowFileToolStripMenuItem";
            this.plotFlowFileToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.plotFlowFileToolStripMenuItem.Text = "Plot flow file";
            this.plotFlowFileToolStripMenuItem.Click += new System.EventHandler(this.plotFlowFileToolStripMenuItem_Click);
            // 
            // panel_pump_panel1
            // 
            this.panel_pump_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_pump_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pump_panel1.Controls.Add(this.checkBox_sequence1);
            this.panel_pump_panel1.Controls.Add(this.label_sequence_name1);
            this.panel_pump_panel1.Controls.Add(this.label_sequence1);
            this.panel_pump_panel1.HorizontalScrollbarBarColor = true;
            this.panel_pump_panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel1.HorizontalScrollbarSize = 10;
            this.panel_pump_panel1.Location = new System.Drawing.Point(7, 454);
            this.panel_pump_panel1.Name = "panel_pump_panel1";
            this.panel_pump_panel1.Size = new System.Drawing.Size(790, 26);
            this.panel_pump_panel1.TabIndex = 6;
            this.panel_pump_panel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_pump_panel1.VerticalScrollbarBarColor = true;
            this.panel_pump_panel1.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel1.VerticalScrollbarSize = 10;
            // 
            // checkBox_sequence1
            // 
            this.checkBox_sequence1.AutoSize = true;
            this.checkBox_sequence1.Location = new System.Drawing.Point(6, 6);
            this.checkBox_sequence1.Name = "checkBox_sequence1";
            this.checkBox_sequence1.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence1.TabIndex = 4;
            this.checkBox_sequence1.Text = " ";
            this.checkBox_sequence1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence1.UseSelectable = true;
            this.checkBox_sequence1.CheckedChanged += new System.EventHandler(this.checkBox_sequence1_CheckedChanged);
            // 
            // label_sequence_name1
            // 
            this.label_sequence_name1.AutoSize = true;
            this.label_sequence_name1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_sequence_name1.Location = new System.Drawing.Point(29, 2);
            this.label_sequence_name1.Name = "label_sequence_name1";
            this.label_sequence_name1.Size = new System.Drawing.Size(112, 19);
            this.label_sequence_name1.TabIndex = 3;
            this.label_sequence_name1.Text = "sequence name";
            this.label_sequence_name1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence_name1.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // label_sequence1
            // 
            this.label_sequence1.AutoSize = true;
            this.label_sequence1.Location = new System.Drawing.Point(146, 2);
            this.label_sequence1.Name = "label_sequence1";
            this.label_sequence1.Size = new System.Drawing.Size(498, 19);
            this.label_sequence1.TabIndex = 2;
            this.label_sequence1.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     0.00ml     0min0s     " +
    "pump 1";
            this.label_sequence1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence1.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // panel_data_description
            // 
            this.panel_data_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_data_description.Controls.Add(this.button_copy);
            this.panel_data_description.Controls.Add(this.listBox_pump_comunication);
            this.panel_data_description.Controls.Add(this.textBox_note);
            this.panel_data_description.Controls.Add(this.metroLabel10);
            this.panel_data_description.Controls.Add(this.maskedTextBox_date_seeded);
            this.panel_data_description.Controls.Add(this.metroLabel9);
            this.panel_data_description.Controls.Add(this.numericUpDown_well_position);
            this.panel_data_description.Controls.Add(this.metroLabel8);
            this.panel_data_description.Controls.Add(this.textBox_cells);
            this.panel_data_description.Controls.Add(this.metroLabel7);
            this.panel_data_description.Controls.Add(this.textBox_experiment);
            this.panel_data_description.Controls.Add(this.numericUpDown_FOV);
            this.panel_data_description.Controls.Add(this.metroLabel6);
            this.panel_data_description.Controls.Add(this.numericUpDown_well);
            this.panel_data_description.Controls.Add(this.metroLabel5);
            this.panel_data_description.Controls.Add(this.numericUpDown_WP);
            this.panel_data_description.Controls.Add(this.metroLabel4);
            this.panel_data_description.Controls.Add(this.metroLabel3);
            this.panel_data_description.Controls.Add(this.metroLabel2);
            this.panel_data_description.Controls.Add(this.textBox_filename);
            this.panel_data_description.Controls.Add(this.numericUpDown_number);
            this.panel_data_description.Controls.Add(this.metroLabel1);
            this.panel_data_description.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel_data_description.HorizontalScrollbarBarColor = true;
            this.panel_data_description.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_data_description.HorizontalScrollbarSize = 10;
            this.panel_data_description.Location = new System.Drawing.Point(820, 439);
            this.panel_data_description.Name = "panel_data_description";
            this.panel_data_description.Size = new System.Drawing.Size(465, 238);
            this.panel_data_description.TabIndex = 7;
            this.panel_data_description.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_data_description.VerticalScrollbarBarColor = true;
            this.panel_data_description.VerticalScrollbarHighlightOnWheel = false;
            this.panel_data_description.VerticalScrollbarSize = 10;
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(366, 187);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(60, 18);
            this.button_copy.TabIndex = 22;
            this.button_copy.Text = "copy";
            this.button_copy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_copy.UseSelectable = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // listBox_pump_comunication
            // 
            this.listBox_pump_comunication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox_pump_comunication.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.listBox_pump_comunication.FormattingEnabled = true;
            this.listBox_pump_comunication.Location = new System.Drawing.Point(69, 3);
            this.listBox_pump_comunication.Name = "listBox_pump_comunication";
            this.listBox_pump_comunication.Size = new System.Drawing.Size(300, 4);
            this.listBox_pump_comunication.TabIndex = 17;
            this.listBox_pump_comunication.Visible = false;
            // 
            // textBox_note
            // 
            // 
            // 
            // 
            this.textBox_note.CustomButton.Image = null;
            this.textBox_note.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.textBox_note.CustomButton.Name = "";
            this.textBox_note.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_note.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_note.CustomButton.TabIndex = 1;
            this.textBox_note.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_note.CustomButton.UseSelectable = true;
            this.textBox_note.CustomButton.Visible = false;
            this.textBox_note.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox_note.Lines = new string[0];
            this.textBox_note.Location = new System.Drawing.Point(100, 177);
            this.textBox_note.MaxLength = 32767;
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.PasswordChar = '\0';
            this.textBox_note.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_note.SelectedText = "";
            this.textBox_note.SelectionLength = 0;
            this.textBox_note.SelectionStart = 0;
            this.textBox_note.ShortcutsEnabled = true;
            this.textBox_note.Size = new System.Drawing.Size(213, 23);
            this.textBox_note.TabIndex = 21;
            this.textBox_note.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox_note.UseSelectable = true;
            this.textBox_note.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_note.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_note.TextChanged += new System.EventHandler(this.textBox_note_TextChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(18, 177);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(35, 19);
            this.metroLabel10.TabIndex = 20;
            this.metroLabel10.Text = "note";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // maskedTextBox_date_seeded
            // 
            // 
            // 
            // 
            this.maskedTextBox_date_seeded.CustomButton.Image = null;
            this.maskedTextBox_date_seeded.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.maskedTextBox_date_seeded.CustomButton.Name = "";
            this.maskedTextBox_date_seeded.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.maskedTextBox_date_seeded.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.maskedTextBox_date_seeded.CustomButton.TabIndex = 1;
            this.maskedTextBox_date_seeded.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.maskedTextBox_date_seeded.CustomButton.UseSelectable = true;
            this.maskedTextBox_date_seeded.CustomButton.Visible = false;
            this.maskedTextBox_date_seeded.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.maskedTextBox_date_seeded.Lines = new string[] {
        "24.12.2022 10:56"};
            this.maskedTextBox_date_seeded.Location = new System.Drawing.Point(99, 149);
            this.maskedTextBox_date_seeded.MaxLength = 32767;
            this.maskedTextBox_date_seeded.Name = "maskedTextBox_date_seeded";
            this.maskedTextBox_date_seeded.PasswordChar = '\0';
            this.maskedTextBox_date_seeded.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maskedTextBox_date_seeded.SelectedText = "";
            this.maskedTextBox_date_seeded.SelectionLength = 0;
            this.maskedTextBox_date_seeded.SelectionStart = 0;
            this.maskedTextBox_date_seeded.ShortcutsEnabled = true;
            this.maskedTextBox_date_seeded.Size = new System.Drawing.Size(213, 23);
            this.maskedTextBox_date_seeded.TabIndex = 19;
            this.maskedTextBox_date_seeded.Text = "24.12.2022 10:56";
            this.maskedTextBox_date_seeded.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.maskedTextBox_date_seeded.UseSelectable = true;
            this.maskedTextBox_date_seeded.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.maskedTextBox_date_seeded.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.maskedTextBox_date_seeded.TextChanged += new System.EventHandler(this.textBox_note_TextChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(17, 149);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(81, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "date seeded";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // numericUpDown_well_position
            // 
            this.numericUpDown_well_position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numericUpDown_well_position.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown_well_position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_well_position.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_well_position.DecimalPlaces = 2;
            this.numericUpDown_well_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_well_position.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numericUpDown_well_position.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_well_position.Location = new System.Drawing.Point(100, 117);
            this.numericUpDown_well_position.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_well_position.Name = "numericUpDown_well_position";
            this.numericUpDown_well_position.Size = new System.Drawing.Size(98, 24);
            this.numericUpDown_well_position.TabIndex = 17;
            this.numericUpDown_well_position.ValueChanged += new System.EventHandler(this.textBox_note_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(17, 117);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(79, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "wll L border";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox_cells
            // 
            // 
            // 
            // 
            this.textBox_cells.CustomButton.Image = null;
            this.textBox_cells.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.textBox_cells.CustomButton.Name = "";
            this.textBox_cells.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_cells.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_cells.CustomButton.TabIndex = 1;
            this.textBox_cells.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_cells.CustomButton.UseSelectable = true;
            this.textBox_cells.CustomButton.Visible = false;
            this.textBox_cells.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox_cells.Lines = new string[] {
        "cells_treatment"};
            this.textBox_cells.Location = new System.Drawing.Point(99, 85);
            this.textBox_cells.MaxLength = 32767;
            this.textBox_cells.Name = "textBox_cells";
            this.textBox_cells.PasswordChar = '\0';
            this.textBox_cells.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_cells.SelectedText = "";
            this.textBox_cells.SelectionLength = 0;
            this.textBox_cells.SelectionStart = 0;
            this.textBox_cells.ShortcutsEnabled = true;
            this.textBox_cells.Size = new System.Drawing.Size(213, 23);
            this.textBox_cells.TabIndex = 15;
            this.textBox_cells.Text = "cells_treatment";
            this.textBox_cells.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox_cells.UseSelectable = true;
            this.textBox_cells.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_cells.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_cells.TextChanged += new System.EventHandler(this.textBox_note_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(17, 85);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(33, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "cells";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox_experiment
            // 
            // 
            // 
            // 
            this.textBox_experiment.CustomButton.Image = null;
            this.textBox_experiment.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.textBox_experiment.CustomButton.Name = "";
            this.textBox_experiment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_experiment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_experiment.CustomButton.TabIndex = 1;
            this.textBox_experiment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_experiment.CustomButton.UseSelectable = true;
            this.textBox_experiment.CustomButton.Visible = false;
            this.textBox_experiment.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox_experiment.Lines = new string[] {
        "experiment_name"};
            this.textBox_experiment.Location = new System.Drawing.Point(99, 53);
            this.textBox_experiment.MaxLength = 32767;
            this.textBox_experiment.Name = "textBox_experiment";
            this.textBox_experiment.PasswordChar = '\0';
            this.textBox_experiment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_experiment.SelectedText = "";
            this.textBox_experiment.SelectionLength = 0;
            this.textBox_experiment.SelectionStart = 0;
            this.textBox_experiment.ShortcutsEnabled = true;
            this.textBox_experiment.Size = new System.Drawing.Size(213, 23);
            this.textBox_experiment.TabIndex = 13;
            this.textBox_experiment.Text = "experiment_name";
            this.textBox_experiment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox_experiment.UseSelectable = true;
            this.textBox_experiment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_experiment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_experiment.TextChanged += new System.EventHandler(this.textBox_note_TextChanged);
            // 
            // numericUpDown_FOV
            // 
            this.numericUpDown_FOV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numericUpDown_FOV.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown_FOV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_FOV.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_FOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_FOV.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numericUpDown_FOV.Location = new System.Drawing.Point(359, 12);
            this.numericUpDown_FOV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FOV.Name = "numericUpDown_FOV";
            this.numericUpDown_FOV.Size = new System.Drawing.Size(38, 24);
            this.numericUpDown_FOV.TabIndex = 12;
            this.numericUpDown_FOV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FOV.ValueChanged += new System.EventHandler(this.textBox_note_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(319, 13);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "FOV";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // numericUpDown_well
            // 
            this.numericUpDown_well.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numericUpDown_well.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown_well.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_well.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_well.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_well.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numericUpDown_well.Location = new System.Drawing.Point(259, 12);
            this.numericUpDown_well.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_well.Name = "numericUpDown_well";
            this.numericUpDown_well.Size = new System.Drawing.Size(38, 24);
            this.numericUpDown_well.TabIndex = 10;
            this.numericUpDown_well.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_well.ValueChanged += new System.EventHandler(this.textBox_note_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(228, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "well";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // numericUpDown_WP
            // 
            this.numericUpDown_WP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numericUpDown_WP.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown_WP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_WP.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_WP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_WP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numericUpDown_WP.Location = new System.Drawing.Point(172, 12);
            this.numericUpDown_WP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_WP.Name = "numericUpDown_WP";
            this.numericUpDown_WP.Size = new System.Drawing.Size(38, 24);
            this.numericUpDown_WP.TabIndex = 8;
            this.numericUpDown_WP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_WP.ValueChanged += new System.EventHandler(this.textBox_note_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(136, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "WP";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 53);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "experiment";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-2, 209);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "filename";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox_filename
            // 
            // 
            // 
            // 
            this.textBox_filename.CustomButton.Image = null;
            this.textBox_filename.CustomButton.Location = new System.Drawing.Point(368, 1);
            this.textBox_filename.CustomButton.Name = "";
            this.textBox_filename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_filename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_filename.CustomButton.TabIndex = 1;
            this.textBox_filename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_filename.CustomButton.UseSelectable = true;
            this.textBox_filename.CustomButton.Visible = false;
            this.textBox_filename.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox_filename.Lines = new string[] {
        "filename"};
            this.textBox_filename.Location = new System.Drawing.Point(57, 206);
            this.textBox_filename.MaxLength = 32767;
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.PasswordChar = '\0';
            this.textBox_filename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_filename.SelectedText = "";
            this.textBox_filename.SelectionLength = 0;
            this.textBox_filename.SelectionStart = 0;
            this.textBox_filename.ShortcutsEnabled = true;
            this.textBox_filename.Size = new System.Drawing.Size(390, 23);
            this.textBox_filename.TabIndex = 4;
            this.textBox_filename.Text = "filename";
            this.textBox_filename.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox_filename.UseSelectable = true;
            this.textBox_filename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_filename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // numericUpDown_number
            // 
            this.numericUpDown_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numericUpDown_number.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_number.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_number.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numericUpDown_number.Location = new System.Drawing.Point(69, 12);
            this.numericUpDown_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_number.Name = "numericUpDown_number";
            this.numericUpDown_number.Size = new System.Drawing.Size(38, 24);
            this.numericUpDown_number.TabIndex = 3;
            this.numericUpDown_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_number.ValueChanged += new System.EventHandler(this.textBox_note_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "number";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel_pump_panel2
            // 
            this.panel_pump_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_pump_panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pump_panel2.Controls.Add(this.checkBox_sequence2);
            this.panel_pump_panel2.Controls.Add(this.label_sequence_name2);
            this.panel_pump_panel2.Controls.Add(this.label_sequence2);
            this.panel_pump_panel2.HorizontalScrollbarBarColor = true;
            this.panel_pump_panel2.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel2.HorizontalScrollbarSize = 10;
            this.panel_pump_panel2.Location = new System.Drawing.Point(7, 486);
            this.panel_pump_panel2.Name = "panel_pump_panel2";
            this.panel_pump_panel2.Size = new System.Drawing.Size(790, 26);
            this.panel_pump_panel2.TabIndex = 8;
            this.panel_pump_panel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_pump_panel2.VerticalScrollbarBarColor = true;
            this.panel_pump_panel2.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel2.VerticalScrollbarSize = 10;
            // 
            // checkBox_sequence2
            // 
            this.checkBox_sequence2.AutoSize = true;
            this.checkBox_sequence2.Location = new System.Drawing.Point(6, 6);
            this.checkBox_sequence2.Name = "checkBox_sequence2";
            this.checkBox_sequence2.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence2.TabIndex = 4;
            this.checkBox_sequence2.Text = " ";
            this.checkBox_sequence2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence2.UseSelectable = true;
            this.checkBox_sequence2.CheckedChanged += new System.EventHandler(this.checkBox_sequence1_CheckedChanged);
            // 
            // label_sequence_name2
            // 
            this.label_sequence_name2.AutoSize = true;
            this.label_sequence_name2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_sequence_name2.Location = new System.Drawing.Point(29, 2);
            this.label_sequence_name2.Name = "label_sequence_name2";
            this.label_sequence_name2.Size = new System.Drawing.Size(112, 19);
            this.label_sequence_name2.TabIndex = 3;
            this.label_sequence_name2.Text = "sequence name";
            this.label_sequence_name2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence_name2.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // label_sequence2
            // 
            this.label_sequence2.AutoSize = true;
            this.label_sequence2.Location = new System.Drawing.Point(146, 2);
            this.label_sequence2.Name = "label_sequence2";
            this.label_sequence2.Size = new System.Drawing.Size(498, 19);
            this.label_sequence2.TabIndex = 2;
            this.label_sequence2.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     0.00ml     0min0s     " +
    "pump 1";
            this.label_sequence2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence2.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // panel_pump_panel3
            // 
            this.panel_pump_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_pump_panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pump_panel3.Controls.Add(this.checkBox_sequence3);
            this.panel_pump_panel3.Controls.Add(this.label_sequence_name3);
            this.panel_pump_panel3.Controls.Add(this.label_sequence3);
            this.panel_pump_panel3.HorizontalScrollbarBarColor = true;
            this.panel_pump_panel3.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel3.HorizontalScrollbarSize = 10;
            this.panel_pump_panel3.Location = new System.Drawing.Point(7, 518);
            this.panel_pump_panel3.Name = "panel_pump_panel3";
            this.panel_pump_panel3.Size = new System.Drawing.Size(790, 26);
            this.panel_pump_panel3.TabIndex = 9;
            this.panel_pump_panel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_pump_panel3.VerticalScrollbarBarColor = true;
            this.panel_pump_panel3.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel3.VerticalScrollbarSize = 10;
            // 
            // checkBox_sequence3
            // 
            this.checkBox_sequence3.AutoSize = true;
            this.checkBox_sequence3.Location = new System.Drawing.Point(6, 6);
            this.checkBox_sequence3.Name = "checkBox_sequence3";
            this.checkBox_sequence3.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence3.TabIndex = 4;
            this.checkBox_sequence3.Text = " ";
            this.checkBox_sequence3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence3.UseSelectable = true;
            this.checkBox_sequence3.CheckedChanged += new System.EventHandler(this.checkBox_sequence1_CheckedChanged);
            // 
            // label_sequence_name3
            // 
            this.label_sequence_name3.AutoSize = true;
            this.label_sequence_name3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_sequence_name3.Location = new System.Drawing.Point(29, 2);
            this.label_sequence_name3.Name = "label_sequence_name3";
            this.label_sequence_name3.Size = new System.Drawing.Size(112, 19);
            this.label_sequence_name3.TabIndex = 3;
            this.label_sequence_name3.Text = "sequence name";
            this.label_sequence_name3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence_name3.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // label_sequence3
            // 
            this.label_sequence3.AutoSize = true;
            this.label_sequence3.Location = new System.Drawing.Point(146, 2);
            this.label_sequence3.Name = "label_sequence3";
            this.label_sequence3.Size = new System.Drawing.Size(498, 19);
            this.label_sequence3.TabIndex = 2;
            this.label_sequence3.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     0.00ml     0min0s     " +
    "pump 1";
            this.label_sequence3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence3.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // panel_pump_panel4
            // 
            this.panel_pump_panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_pump_panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pump_panel4.Controls.Add(this.checkBox_sequence4);
            this.panel_pump_panel4.Controls.Add(this.label_sequence_name4);
            this.panel_pump_panel4.Controls.Add(this.label_sequence4);
            this.panel_pump_panel4.HorizontalScrollbarBarColor = true;
            this.panel_pump_panel4.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel4.HorizontalScrollbarSize = 10;
            this.panel_pump_panel4.Location = new System.Drawing.Point(7, 550);
            this.panel_pump_panel4.Name = "panel_pump_panel4";
            this.panel_pump_panel4.Size = new System.Drawing.Size(790, 26);
            this.panel_pump_panel4.TabIndex = 10;
            this.panel_pump_panel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_pump_panel4.VerticalScrollbarBarColor = true;
            this.panel_pump_panel4.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel4.VerticalScrollbarSize = 10;
            // 
            // checkBox_sequence4
            // 
            this.checkBox_sequence4.AutoSize = true;
            this.checkBox_sequence4.Location = new System.Drawing.Point(6, 6);
            this.checkBox_sequence4.Name = "checkBox_sequence4";
            this.checkBox_sequence4.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence4.TabIndex = 4;
            this.checkBox_sequence4.Text = " ";
            this.checkBox_sequence4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence4.UseSelectable = true;
            this.checkBox_sequence4.CheckedChanged += new System.EventHandler(this.checkBox_sequence1_CheckedChanged);
            // 
            // label_sequence_name4
            // 
            this.label_sequence_name4.AutoSize = true;
            this.label_sequence_name4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_sequence_name4.Location = new System.Drawing.Point(29, 2);
            this.label_sequence_name4.Name = "label_sequence_name4";
            this.label_sequence_name4.Size = new System.Drawing.Size(112, 19);
            this.label_sequence_name4.TabIndex = 3;
            this.label_sequence_name4.Text = "sequence name";
            this.label_sequence_name4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence_name4.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // label_sequence4
            // 
            this.label_sequence4.AutoSize = true;
            this.label_sequence4.Location = new System.Drawing.Point(146, 2);
            this.label_sequence4.Name = "label_sequence4";
            this.label_sequence4.Size = new System.Drawing.Size(498, 19);
            this.label_sequence4.TabIndex = 2;
            this.label_sequence4.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     0.00ml     0min0s     " +
    "pump 1";
            this.label_sequence4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence4.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // panel_pump_panel5
            // 
            this.panel_pump_panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_pump_panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pump_panel5.Controls.Add(this.checkBox_sequence5);
            this.panel_pump_panel5.Controls.Add(this.label_sequence_name5);
            this.panel_pump_panel5.Controls.Add(this.label_sequence5);
            this.panel_pump_panel5.HorizontalScrollbarBarColor = true;
            this.panel_pump_panel5.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel5.HorizontalScrollbarSize = 10;
            this.panel_pump_panel5.Location = new System.Drawing.Point(7, 582);
            this.panel_pump_panel5.Name = "panel_pump_panel5";
            this.panel_pump_panel5.Size = new System.Drawing.Size(790, 26);
            this.panel_pump_panel5.TabIndex = 11;
            this.panel_pump_panel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_pump_panel5.VerticalScrollbarBarColor = true;
            this.panel_pump_panel5.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel5.VerticalScrollbarSize = 10;
            // 
            // checkBox_sequence5
            // 
            this.checkBox_sequence5.AutoSize = true;
            this.checkBox_sequence5.Location = new System.Drawing.Point(6, 6);
            this.checkBox_sequence5.Name = "checkBox_sequence5";
            this.checkBox_sequence5.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence5.TabIndex = 4;
            this.checkBox_sequence5.Text = " ";
            this.checkBox_sequence5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence5.UseSelectable = true;
            this.checkBox_sequence5.CheckedChanged += new System.EventHandler(this.checkBox_sequence1_CheckedChanged);
            // 
            // label_sequence_name5
            // 
            this.label_sequence_name5.AutoSize = true;
            this.label_sequence_name5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_sequence_name5.Location = new System.Drawing.Point(29, 2);
            this.label_sequence_name5.Name = "label_sequence_name5";
            this.label_sequence_name5.Size = new System.Drawing.Size(112, 19);
            this.label_sequence_name5.TabIndex = 3;
            this.label_sequence_name5.Text = "sequence name";
            this.label_sequence_name5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence_name5.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // label_sequence5
            // 
            this.label_sequence5.AutoSize = true;
            this.label_sequence5.Location = new System.Drawing.Point(146, 2);
            this.label_sequence5.Name = "label_sequence5";
            this.label_sequence5.Size = new System.Drawing.Size(498, 19);
            this.label_sequence5.TabIndex = 2;
            this.label_sequence5.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     0.00ml     0min0s     " +
    "pump 1";
            this.label_sequence5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence5.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // panel_pump_panel6
            // 
            this.panel_pump_panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_pump_panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pump_panel6.Controls.Add(this.checkBox_sequence6);
            this.panel_pump_panel6.Controls.Add(this.label_sequence_name6);
            this.panel_pump_panel6.Controls.Add(this.label_sequence6);
            this.panel_pump_panel6.HorizontalScrollbarBarColor = true;
            this.panel_pump_panel6.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel6.HorizontalScrollbarSize = 10;
            this.panel_pump_panel6.Location = new System.Drawing.Point(7, 614);
            this.panel_pump_panel6.Name = "panel_pump_panel6";
            this.panel_pump_panel6.Size = new System.Drawing.Size(790, 26);
            this.panel_pump_panel6.TabIndex = 12;
            this.panel_pump_panel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_pump_panel6.VerticalScrollbarBarColor = true;
            this.panel_pump_panel6.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel6.VerticalScrollbarSize = 10;
            // 
            // checkBox_sequence6
            // 
            this.checkBox_sequence6.AutoSize = true;
            this.checkBox_sequence6.Location = new System.Drawing.Point(6, 6);
            this.checkBox_sequence6.Name = "checkBox_sequence6";
            this.checkBox_sequence6.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence6.TabIndex = 4;
            this.checkBox_sequence6.Text = " ";
            this.checkBox_sequence6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence6.UseSelectable = true;
            this.checkBox_sequence6.CheckedChanged += new System.EventHandler(this.checkBox_sequence1_CheckedChanged);
            // 
            // label_sequence_name6
            // 
            this.label_sequence_name6.AutoSize = true;
            this.label_sequence_name6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_sequence_name6.Location = new System.Drawing.Point(29, 2);
            this.label_sequence_name6.Name = "label_sequence_name6";
            this.label_sequence_name6.Size = new System.Drawing.Size(112, 19);
            this.label_sequence_name6.TabIndex = 3;
            this.label_sequence_name6.Text = "sequence name";
            this.label_sequence_name6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence_name6.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // label_sequence6
            // 
            this.label_sequence6.AutoSize = true;
            this.label_sequence6.Location = new System.Drawing.Point(146, 2);
            this.label_sequence6.Name = "label_sequence6";
            this.label_sequence6.Size = new System.Drawing.Size(498, 19);
            this.label_sequence6.TabIndex = 2;
            this.label_sequence6.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     0.00ml     0min0s     " +
    "pump 1";
            this.label_sequence6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence6.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // panel_pump_panel7
            // 
            this.panel_pump_panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_pump_panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pump_panel7.Controls.Add(this.checkBox_sequence7);
            this.panel_pump_panel7.Controls.Add(this.label_sequence_name7);
            this.panel_pump_panel7.Controls.Add(this.label_sequence7);
            this.panel_pump_panel7.HorizontalScrollbarBarColor = true;
            this.panel_pump_panel7.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel7.HorizontalScrollbarSize = 10;
            this.panel_pump_panel7.Location = new System.Drawing.Point(7, 646);
            this.panel_pump_panel7.Name = "panel_pump_panel7";
            this.panel_pump_panel7.Size = new System.Drawing.Size(790, 26);
            this.panel_pump_panel7.TabIndex = 13;
            this.panel_pump_panel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_pump_panel7.VerticalScrollbarBarColor = true;
            this.panel_pump_panel7.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pump_panel7.VerticalScrollbarSize = 10;
            // 
            // checkBox_sequence7
            // 
            this.checkBox_sequence7.AutoSize = true;
            this.checkBox_sequence7.Location = new System.Drawing.Point(6, 6);
            this.checkBox_sequence7.Name = "checkBox_sequence7";
            this.checkBox_sequence7.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence7.TabIndex = 4;
            this.checkBox_sequence7.Text = " ";
            this.checkBox_sequence7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence7.UseSelectable = true;
            this.checkBox_sequence7.CheckedChanged += new System.EventHandler(this.checkBox_sequence1_CheckedChanged);
            // 
            // label_sequence_name7
            // 
            this.label_sequence_name7.AutoSize = true;
            this.label_sequence_name7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_sequence_name7.Location = new System.Drawing.Point(29, 2);
            this.label_sequence_name7.Name = "label_sequence_name7";
            this.label_sequence_name7.Size = new System.Drawing.Size(112, 19);
            this.label_sequence_name7.TabIndex = 3;
            this.label_sequence_name7.Text = "sequence name";
            this.label_sequence_name7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence_name7.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // label_sequence7
            // 
            this.label_sequence7.AutoSize = true;
            this.label_sequence7.Location = new System.Drawing.Point(146, 2);
            this.label_sequence7.Name = "label_sequence7";
            this.label_sequence7.Size = new System.Drawing.Size(498, 19);
            this.label_sequence7.TabIndex = 2;
            this.label_sequence7.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     0.00ml     0min0s     " +
    "pump 1";
            this.label_sequence7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_sequence7.Click += new System.EventHandler(this.label_sequence_Click);
            // 
            // label_COM_flow
            // 
            this.label_COM_flow.AutoSize = true;
            this.label_COM_flow.Location = new System.Drawing.Point(442, 695);
            this.label_COM_flow.Name = "label_COM_flow";
            this.label_COM_flow.Size = new System.Drawing.Size(28, 19);
            this.label_COM_flow.TabIndex = 14;
            this.label_COM_flow.Text = "NA";
            this.label_COM_flow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_COM_flow.Click += new System.EventHandler(this.label_COM_flow_Click);
            // 
            // checkBox_show_plot
            // 
            this.checkBox_show_plot.AutoSize = true;
            this.checkBox_show_plot.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkBox_show_plot.Location = new System.Drawing.Point(617, 689);
            this.checkBox_show_plot.Name = "checkBox_show_plot";
            this.checkBox_show_plot.Size = new System.Drawing.Size(85, 19);
            this.checkBox_show_plot.TabIndex = 15;
            this.checkBox_show_plot.Text = "show plot";
            this.checkBox_show_plot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_show_plot.UseSelectable = true;
            this.checkBox_show_plot.CheckedChanged += new System.EventHandler(this.checkBox_show_plot_CheckedChanged);
            // 
            // label_COM_pump
            // 
            this.label_COM_pump.AutoSize = true;
            this.label_COM_pump.Location = new System.Drawing.Point(517, 696);
            this.label_COM_pump.Name = "label_COM_pump";
            this.label_COM_pump.Size = new System.Drawing.Size(28, 19);
            this.label_COM_pump.TabIndex = 16;
            this.label_COM_pump.Text = "NA";
            this.label_COM_pump.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_COM_pump.Click += new System.EventHandler(this.label_COM_pump_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(429, 679);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(68, 19);
            this.metroLabel11.TabIndex = 17;
            this.metroLabel11.Text = "flowmeter";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(510, 679);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(44, 19);
            this.metroLabel12.TabIndex = 18;
            this.metroLabel12.Text = "pump";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Location = new System.Drawing.Point(938, 690);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(40, 19);
            this.label_timer.TabIndex = 19;
            this.label_timer.Text = "timer";
            this.label_timer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox_pa_is_xx_ml_min
            // 
            // 
            // 
            // 
            this.textBox_pa_is_xx_ml_min.CustomButton.Image = null;
            this.textBox_pa_is_xx_ml_min.CustomButton.Location = new System.Drawing.Point(-12, 1);
            this.textBox_pa_is_xx_ml_min.CustomButton.Name = "";
            this.textBox_pa_is_xx_ml_min.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_pa_is_xx_ml_min.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_pa_is_xx_ml_min.CustomButton.TabIndex = 1;
            this.textBox_pa_is_xx_ml_min.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_pa_is_xx_ml_min.CustomButton.UseSelectable = true;
            this.textBox_pa_is_xx_ml_min.CustomButton.Visible = false;
            this.textBox_pa_is_xx_ml_min.Lines = new string[] {
        "0.1298"};
            this.textBox_pa_is_xx_ml_min.Location = new System.Drawing.Point(3, 5);
            this.textBox_pa_is_xx_ml_min.MaxLength = 32767;
            this.textBox_pa_is_xx_ml_min.Name = "textBox_pa_is_xx_ml_min";
            this.textBox_pa_is_xx_ml_min.PasswordChar = '\0';
            this.textBox_pa_is_xx_ml_min.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_pa_is_xx_ml_min.SelectedText = "";
            this.textBox_pa_is_xx_ml_min.SelectionLength = 0;
            this.textBox_pa_is_xx_ml_min.SelectionStart = 0;
            this.textBox_pa_is_xx_ml_min.ShortcutsEnabled = true;
            this.textBox_pa_is_xx_ml_min.Size = new System.Drawing.Size(10, 23);
            this.textBox_pa_is_xx_ml_min.TabIndex = 20;
            this.textBox_pa_is_xx_ml_min.Text = "0.1298";
            this.textBox_pa_is_xx_ml_min.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox_pa_is_xx_ml_min.UseSelectable = true;
            this.textBox_pa_is_xx_ml_min.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_pa_is_xx_ml_min.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox_time_reserve_s
            // 
            // 
            // 
            // 
            this.textBox_time_reserve_s.CustomButton.Image = null;
            this.textBox_time_reserve_s.CustomButton.Location = new System.Drawing.Point(-12, 1);
            this.textBox_time_reserve_s.CustomButton.Name = "";
            this.textBox_time_reserve_s.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_time_reserve_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_time_reserve_s.CustomButton.TabIndex = 1;
            this.textBox_time_reserve_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_time_reserve_s.CustomButton.UseSelectable = true;
            this.textBox_time_reserve_s.CustomButton.Visible = false;
            this.textBox_time_reserve_s.Lines = new string[] {
        "20"};
            this.textBox_time_reserve_s.Location = new System.Drawing.Point(19, 6);
            this.textBox_time_reserve_s.MaxLength = 32767;
            this.textBox_time_reserve_s.Name = "textBox_time_reserve_s";
            this.textBox_time_reserve_s.PasswordChar = '\0';
            this.textBox_time_reserve_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_time_reserve_s.SelectedText = "";
            this.textBox_time_reserve_s.SelectionLength = 0;
            this.textBox_time_reserve_s.SelectionStart = 0;
            this.textBox_time_reserve_s.ShortcutsEnabled = true;
            this.textBox_time_reserve_s.Size = new System.Drawing.Size(10, 23);
            this.textBox_time_reserve_s.TabIndex = 21;
            this.textBox_time_reserve_s.Text = "20";
            this.textBox_time_reserve_s.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox_time_reserve_s.UseSelectable = true;
            this.textBox_time_reserve_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_time_reserve_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.textBox_diameter);
            this.metroPanel1.Controls.Add(this.numericUpDown_num_of_seq);
            this.metroPanel1.Controls.Add(this.textBox_time_reserve_s);
            this.metroPanel1.Controls.Add(this.textBox_pa_is_xx_ml_min);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(7, 679);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(85, 35);
            this.metroPanel1.TabIndex = 22;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // textBox_diameter
            // 
            // 
            // 
            // 
            this.textBox_diameter.CustomButton.Image = null;
            this.textBox_diameter.CustomButton.Location = new System.Drawing.Point(-12, 1);
            this.textBox_diameter.CustomButton.Name = "";
            this.textBox_diameter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_diameter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_diameter.CustomButton.TabIndex = 1;
            this.textBox_diameter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_diameter.CustomButton.UseSelectable = true;
            this.textBox_diameter.CustomButton.Visible = false;
            this.textBox_diameter.Lines = new string[] {
        "20"};
            this.textBox_diameter.Location = new System.Drawing.Point(47, 5);
            this.textBox_diameter.MaxLength = 32767;
            this.textBox_diameter.Name = "textBox_diameter";
            this.textBox_diameter.PasswordChar = '\0';
            this.textBox_diameter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_diameter.SelectedText = "";
            this.textBox_diameter.SelectionLength = 0;
            this.textBox_diameter.SelectionStart = 0;
            this.textBox_diameter.ShortcutsEnabled = true;
            this.textBox_diameter.Size = new System.Drawing.Size(10, 23);
            this.textBox_diameter.TabIndex = 23;
            this.textBox_diameter.Text = "20";
            this.textBox_diameter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox_diameter.UseSelectable = true;
            this.textBox_diameter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_diameter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // numericUpDown_num_of_seq
            // 
            this.numericUpDown_num_of_seq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numericUpDown_num_of_seq.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown_num_of_seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_num_of_seq.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_num_of_seq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_num_of_seq.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numericUpDown_num_of_seq.Location = new System.Drawing.Point(33, 5);
            this.numericUpDown_num_of_seq.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown_num_of_seq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_num_of_seq.Name = "numericUpDown_num_of_seq";
            this.numericUpDown_num_of_seq.Size = new System.Drawing.Size(10, 24);
            this.numericUpDown_num_of_seq.TabIndex = 22;
            this.numericUpDown_num_of_seq.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_num_of_seq.ValueChanged += new System.EventHandler(this.numericUpDown_num_of_seq_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1291, 718);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.label_COM_pump);
            this.Controls.Add(this.checkBox_show_plot);
            this.Controls.Add(this.label_COM_flow);
            this.Controls.Add(this.panel_pump_panel7);
            this.Controls.Add(this.panel_pump_panel6);
            this.Controls.Add(this.panel_pump_panel5);
            this.Controls.Add(this.panel_pump_panel4);
            this.Controls.Add(this.panel_pump_panel3);
            this.Controls.Add(this.panel_pump_panel2);
            this.Controls.Add(this.panel_data_description);
            this.Controls.Add(this.panel_pump_panel1);
            this.Controls.Add(this.button_stop_without_recording);
            this.Controls.Add(this.button_start_without_recording);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.chart_flow);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_flow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_pump_panel1.ResumeLayout(false);
            this.panel_pump_panel1.PerformLayout();
            this.panel_data_description.ResumeLayout(false);
            this.panel_data_description.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_well_position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_well)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number)).EndInit();
            this.panel_pump_panel2.ResumeLayout(false);
            this.panel_pump_panel2.PerformLayout();
            this.panel_pump_panel3.ResumeLayout(false);
            this.panel_pump_panel3.PerformLayout();
            this.panel_pump_panel4.ResumeLayout(false);
            this.panel_pump_panel4.PerformLayout();
            this.panel_pump_panel5.ResumeLayout(false);
            this.panel_pump_panel5.PerformLayout();
            this.panel_pump_panel6.ResumeLayout(false);
            this.panel_pump_panel6.PerformLayout();
            this.panel_pump_panel7.ResumeLayout(false);
            this.panel_pump_panel7.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_num_of_seq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_flow;
        public MetroFramework.Controls.MetroLabel label_COM_flow;
        public MetroFramework.Controls.MetroCheckBox checkBox_show_plot;
        public MetroFramework.Controls.MetroTextBox textBox_filename;
        public MetroFramework.Controls.MetroTextBox textBox_cells;
        public MetroFramework.Controls.MetroTextBox textBox_experiment;
        public MetroFramework.Controls.MetroTextBox textBox_note;
        public MetroFramework.Controls.MetroTextBox maskedTextBox_date_seeded;
        public FlatNumericUpDown numericUpDown_well_position;
        public FlatNumericUpDown numericUpDown_FOV;
        public FlatNumericUpDown numericUpDown_well;
        public FlatNumericUpDown numericUpDown_WP;
        public FlatNumericUpDown numericUpDown_number;
        public MetroFramework.Controls.MetroLabel label_COM_pump;
        public System.Windows.Forms.ListBox listBox_pump_comunication;
        public MetroFramework.Controls.MetroButton button_stop;
        public MetroFramework.Controls.MetroButton button_stop_without_recording;
        public MetroFramework.Controls.MetroLabel label_timer;
        public MetroFramework.Controls.MetroTextBox textBox_pa_is_xx_ml_min;
        public MetroFramework.Controls.MetroTextBox textBox_time_reserve_s;
        public FlatNumericUpDown numericUpDown_num_of_seq;
        public MetroFramework.Controls.MetroButton button_start;
        public MetroFramework.Controls.MetroButton button_start_without_recording;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        public MetroFramework.Controls.MetroPanel panel_pump_panel1;
        public MetroFramework.Controls.MetroPanel panel_data_description;
        public MetroFramework.Controls.MetroLabel label_sequence1;
        public MetroFramework.Controls.MetroLabel label_sequence_name1;
        public MetroFramework.Controls.MetroCheckBox checkBox_sequence1;
        public MetroFramework.Controls.MetroPanel panel_pump_panel2;
        public MetroFramework.Controls.MetroCheckBox checkBox_sequence2;
        public MetroFramework.Controls.MetroLabel label_sequence_name2;
        public MetroFramework.Controls.MetroLabel label_sequence2;
        public MetroFramework.Controls.MetroPanel panel_pump_panel3;
        public MetroFramework.Controls.MetroCheckBox checkBox_sequence3;
        public MetroFramework.Controls.MetroLabel label_sequence_name3;
        public MetroFramework.Controls.MetroLabel label_sequence3;
        public MetroFramework.Controls.MetroPanel panel_pump_panel4;
        public MetroFramework.Controls.MetroCheckBox checkBox_sequence4;
        public MetroFramework.Controls.MetroLabel label_sequence_name4;
        public MetroFramework.Controls.MetroLabel label_sequence4;
        public MetroFramework.Controls.MetroPanel panel_pump_panel5;
        public MetroFramework.Controls.MetroCheckBox checkBox_sequence5;
        public MetroFramework.Controls.MetroLabel label_sequence_name5;
        public MetroFramework.Controls.MetroLabel label_sequence5;
        public MetroFramework.Controls.MetroPanel panel_pump_panel6;
        public MetroFramework.Controls.MetroCheckBox checkBox_sequence6;
        public MetroFramework.Controls.MetroLabel label_sequence_name6;
        public MetroFramework.Controls.MetroLabel label_sequence6;
        public MetroFramework.Controls.MetroPanel panel_pump_panel7;
        public MetroFramework.Controls.MetroCheckBox checkBox_sequence7;
        public MetroFramework.Controls.MetroLabel label_sequence_name7;
        public MetroFramework.Controls.MetroLabel label_sequence7;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        public MetroFramework.Controls.MetroLabel metroLabel7;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel10;
        public MetroFramework.Controls.MetroLabel metroLabel9;
        public MetroFramework.Controls.MetroLabel metroLabel11;
        public MetroFramework.Controls.MetroLabel metroLabel12;
        public MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroTextBox textBox_diameter;
        private MetroFramework.Controls.MetroButton button_copy;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotFlowFileToolStripMenuItem;
    }
}

