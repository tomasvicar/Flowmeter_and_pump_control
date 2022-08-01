
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_start = new MetroFramework.Controls.MetroButton();
            this.chart_flow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_stop = new MetroFramework.Controls.MetroButton();
            this.button_start_wo_rec = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfPanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_pump_panel1 = new MetroFramework.Controls.MetroPanel();
            this.checkBox_sequence1 = new MetroFramework.Controls.MetroCheckBox();
            this.label_sequence_name1 = new MetroFramework.Controls.MetroLabel();
            this.label_sequence1 = new MetroFramework.Controls.MetroLabel();
            this.panel_data_description = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox_filename = new MetroFramework.Controls.MetroTextBox();
            this.flatNumericUpDown1 = new FlatNumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart_flow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel_pump_panel1.SuspendLayout();
            this.panel_data_description.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown1)).BeginInit();
            this.panel_pump_panel2.SuspendLayout();
            this.panel_pump_panel3.SuspendLayout();
            this.panel_pump_panel4.SuspendLayout();
            this.panel_pump_panel5.SuspendLayout();
            this.panel_pump_panel6.SuspendLayout();
            this.panel_pump_panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(849, 684);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(76, 25);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "start";
            this.button_start.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_start.UseSelectable = true;
            // 
            // chart_flow
            // 
            this.chart_flow.BackColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chart_flow.ChartAreas.Add(chartArea1);
            this.chart_flow.Location = new System.Drawing.Point(7, 32);
            this.chart_flow.Name = "chart_flow";
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.DarkBlue;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chart_flow.Series.Add(series1);
            this.chart_flow.Size = new System.Drawing.Size(1278, 402);
            this.chart_flow.TabIndex = 1;
            this.chart_flow.Text = "chart1";
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(931, 684);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(76, 25);
            this.button_stop.TabIndex = 2;
            this.button_stop.Text = "stop";
            this.button_stop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_stop.UseSelectable = true;
            // 
            // button_start_wo_rec
            // 
            this.button_start_wo_rec.Location = new System.Drawing.Point(1091, 684);
            this.button_start_wo_rec.Name = "button_start_wo_rec";
            this.button_start_wo_rec.Size = new System.Drawing.Size(76, 25);
            this.button_start_wo_rec.TabIndex = 3;
            this.button_start_wo_rec.Text = "start w/o rec.";
            this.button_start_wo_rec.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_start_wo_rec.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1173, 684);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(76, 25);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "stop w/o rec.";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.numberOfPanelsToolStripMenuItem});
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
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // numberOfPanelsToolStripMenuItem
            // 
            this.numberOfPanelsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numberOfPanelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.numberOfPanelsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numberOfPanelsToolStripMenuItem.Name = "numberOfPanelsToolStripMenuItem";
            this.numberOfPanelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numberOfPanelsToolStripMenuItem.Text = "Number of panels";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "5";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "6";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "7";
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save settings";
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadSettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadSettingsToolStripMenuItem.Text = "Load settings";
            // 
            // panel_pump_panel1
            // 
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
            this.checkBox_sequence1.Location = new System.Drawing.Point(752, 6);
            this.checkBox_sequence1.Name = "checkBox_sequence1";
            this.checkBox_sequence1.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence1.TabIndex = 4;
            this.checkBox_sequence1.Text = " ";
            this.checkBox_sequence1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence1.UseSelectable = true;
            // 
            // label_sequence_name1
            // 
            this.label_sequence_name1.AutoSize = true;
            this.label_sequence_name1.Location = new System.Drawing.Point(10, 2);
            this.label_sequence_name1.Name = "label_sequence_name1";
            this.label_sequence_name1.Size = new System.Drawing.Size(100, 19);
            this.label_sequence_name1.TabIndex = 3;
            this.label_sequence_name1.Text = "sequence name";
            this.label_sequence_name1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_sequence1
            // 
            this.label_sequence1.AutoSize = true;
            this.label_sequence1.Location = new System.Drawing.Point(127, 2);
            this.label_sequence1.Name = "label_sequence1";
            this.label_sequence1.Size = new System.Drawing.Size(502, 19);
            this.label_sequence1.TabIndex = 2;
            this.label_sequence1.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     1.35ml     1min26s    " +
    " pump x";
            this.label_sequence1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel_data_description
            // 
            this.panel_data_description.Controls.Add(this.metroLabel2);
            this.panel_data_description.Controls.Add(this.textBox_filename);
            this.panel_data_description.Controls.Add(this.flatNumericUpDown1);
            this.panel_data_description.Controls.Add(this.metroLabel1);
            this.panel_data_description.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel_data_description.HorizontalScrollbarBarColor = true;
            this.panel_data_description.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_data_description.HorizontalScrollbarSize = 10;
            this.panel_data_description.Location = new System.Drawing.Point(832, 439);
            this.panel_data_description.Name = "panel_data_description";
            this.panel_data_description.Size = new System.Drawing.Size(453, 238);
            this.panel_data_description.TabIndex = 7;
            this.panel_data_description.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_data_description.VerticalScrollbarBarColor = true;
            this.panel_data_description.VerticalScrollbarHighlightOnWheel = false;
            this.panel_data_description.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 209);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "number";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox_filename
            // 
            // 
            // 
            // 
            this.textBox_filename.CustomButton.Image = null;
            this.textBox_filename.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.textBox_filename.CustomButton.Name = "";
            this.textBox_filename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_filename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_filename.CustomButton.TabIndex = 1;
            this.textBox_filename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_filename.CustomButton.UseSelectable = true;
            this.textBox_filename.CustomButton.Visible = false;
            this.textBox_filename.Lines = new string[] {
        "filename"};
            this.textBox_filename.Location = new System.Drawing.Point(78, 207);
            this.textBox_filename.MaxLength = 32767;
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.PasswordChar = '\0';
            this.textBox_filename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_filename.SelectedText = "";
            this.textBox_filename.SelectionLength = 0;
            this.textBox_filename.SelectionStart = 0;
            this.textBox_filename.ShortcutsEnabled = true;
            this.textBox_filename.Size = new System.Drawing.Size(329, 23);
            this.textBox_filename.TabIndex = 4;
            this.textBox_filename.Text = "filename";
            this.textBox_filename.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox_filename.UseSelectable = true;
            this.textBox_filename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_filename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // flatNumericUpDown1
            // 
            this.flatNumericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatNumericUpDown1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatNumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flatNumericUpDown1.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatNumericUpDown1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.flatNumericUpDown1.Location = new System.Drawing.Point(78, 16);
            this.flatNumericUpDown1.Name = "flatNumericUpDown1";
            this.flatNumericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.flatNumericUpDown1.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "number";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel_pump_panel2
            // 
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
            this.checkBox_sequence2.Location = new System.Drawing.Point(752, 6);
            this.checkBox_sequence2.Name = "checkBox_sequence2";
            this.checkBox_sequence2.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence2.TabIndex = 4;
            this.checkBox_sequence2.Text = " ";
            this.checkBox_sequence2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence2.UseSelectable = true;
            // 
            // label_sequence_name2
            // 
            this.label_sequence_name2.AutoSize = true;
            this.label_sequence_name2.Location = new System.Drawing.Point(10, 2);
            this.label_sequence_name2.Name = "label_sequence_name2";
            this.label_sequence_name2.Size = new System.Drawing.Size(100, 19);
            this.label_sequence_name2.TabIndex = 3;
            this.label_sequence_name2.Text = "sequence name";
            this.label_sequence_name2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_sequence2
            // 
            this.label_sequence2.AutoSize = true;
            this.label_sequence2.Location = new System.Drawing.Point(127, 2);
            this.label_sequence2.Name = "label_sequence2";
            this.label_sequence2.Size = new System.Drawing.Size(502, 19);
            this.label_sequence2.TabIndex = 2;
            this.label_sequence2.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     1.35ml     1min26s    " +
    " pump x";
            this.label_sequence2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel_pump_panel3
            // 
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
            this.checkBox_sequence3.Location = new System.Drawing.Point(752, 6);
            this.checkBox_sequence3.Name = "checkBox_sequence3";
            this.checkBox_sequence3.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence3.TabIndex = 4;
            this.checkBox_sequence3.Text = " ";
            this.checkBox_sequence3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence3.UseSelectable = true;
            // 
            // label_sequence_name3
            // 
            this.label_sequence_name3.AutoSize = true;
            this.label_sequence_name3.Location = new System.Drawing.Point(10, 2);
            this.label_sequence_name3.Name = "label_sequence_name3";
            this.label_sequence_name3.Size = new System.Drawing.Size(100, 19);
            this.label_sequence_name3.TabIndex = 3;
            this.label_sequence_name3.Text = "sequence name";
            this.label_sequence_name3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_sequence3
            // 
            this.label_sequence3.AutoSize = true;
            this.label_sequence3.Location = new System.Drawing.Point(127, 2);
            this.label_sequence3.Name = "label_sequence3";
            this.label_sequence3.Size = new System.Drawing.Size(502, 19);
            this.label_sequence3.TabIndex = 2;
            this.label_sequence3.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     1.35ml     1min26s    " +
    " pump x";
            this.label_sequence3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel_pump_panel4
            // 
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
            this.checkBox_sequence4.Location = new System.Drawing.Point(752, 6);
            this.checkBox_sequence4.Name = "checkBox_sequence4";
            this.checkBox_sequence4.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence4.TabIndex = 4;
            this.checkBox_sequence4.Text = " ";
            this.checkBox_sequence4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence4.UseSelectable = true;
            // 
            // label_sequence_name4
            // 
            this.label_sequence_name4.AutoSize = true;
            this.label_sequence_name4.Location = new System.Drawing.Point(10, 2);
            this.label_sequence_name4.Name = "label_sequence_name4";
            this.label_sequence_name4.Size = new System.Drawing.Size(100, 19);
            this.label_sequence_name4.TabIndex = 3;
            this.label_sequence_name4.Text = "sequence name";
            this.label_sequence_name4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_sequence4
            // 
            this.label_sequence4.AutoSize = true;
            this.label_sequence4.Location = new System.Drawing.Point(127, 2);
            this.label_sequence4.Name = "label_sequence4";
            this.label_sequence4.Size = new System.Drawing.Size(502, 19);
            this.label_sequence4.TabIndex = 2;
            this.label_sequence4.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     1.35ml     1min26s    " +
    " pump x";
            this.label_sequence4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel_pump_panel5
            // 
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
            this.checkBox_sequence5.Location = new System.Drawing.Point(752, 6);
            this.checkBox_sequence5.Name = "checkBox_sequence5";
            this.checkBox_sequence5.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence5.TabIndex = 4;
            this.checkBox_sequence5.Text = " ";
            this.checkBox_sequence5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence5.UseSelectable = true;
            // 
            // label_sequence_name5
            // 
            this.label_sequence_name5.AutoSize = true;
            this.label_sequence_name5.Location = new System.Drawing.Point(10, 2);
            this.label_sequence_name5.Name = "label_sequence_name5";
            this.label_sequence_name5.Size = new System.Drawing.Size(100, 19);
            this.label_sequence_name5.TabIndex = 3;
            this.label_sequence_name5.Text = "sequence name";
            this.label_sequence_name5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_sequence5
            // 
            this.label_sequence5.AutoSize = true;
            this.label_sequence5.Location = new System.Drawing.Point(127, 2);
            this.label_sequence5.Name = "label_sequence5";
            this.label_sequence5.Size = new System.Drawing.Size(502, 19);
            this.label_sequence5.TabIndex = 2;
            this.label_sequence5.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     1.35ml     1min26s    " +
    " pump x";
            this.label_sequence5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel_pump_panel6
            // 
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
            this.checkBox_sequence6.Location = new System.Drawing.Point(752, 6);
            this.checkBox_sequence6.Name = "checkBox_sequence6";
            this.checkBox_sequence6.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence6.TabIndex = 4;
            this.checkBox_sequence6.Text = " ";
            this.checkBox_sequence6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence6.UseSelectable = true;
            // 
            // label_sequence_name6
            // 
            this.label_sequence_name6.AutoSize = true;
            this.label_sequence_name6.Location = new System.Drawing.Point(10, 2);
            this.label_sequence_name6.Name = "label_sequence_name6";
            this.label_sequence_name6.Size = new System.Drawing.Size(100, 19);
            this.label_sequence_name6.TabIndex = 3;
            this.label_sequence_name6.Text = "sequence name";
            this.label_sequence_name6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_sequence6
            // 
            this.label_sequence6.AutoSize = true;
            this.label_sequence6.Location = new System.Drawing.Point(127, 2);
            this.label_sequence6.Name = "label_sequence6";
            this.label_sequence6.Size = new System.Drawing.Size(502, 19);
            this.label_sequence6.TabIndex = 2;
            this.label_sequence6.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     1.35ml     1min26s    " +
    " pump x";
            this.label_sequence6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel_pump_panel7
            // 
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
            this.checkBox_sequence7.Location = new System.Drawing.Point(752, 6);
            this.checkBox_sequence7.Name = "checkBox_sequence7";
            this.checkBox_sequence7.Size = new System.Drawing.Size(26, 15);
            this.checkBox_sequence7.TabIndex = 4;
            this.checkBox_sequence7.Text = " ";
            this.checkBox_sequence7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_sequence7.UseSelectable = true;
            // 
            // label_sequence_name7
            // 
            this.label_sequence_name7.AutoSize = true;
            this.label_sequence_name7.Location = new System.Drawing.Point(10, 2);
            this.label_sequence_name7.Name = "label_sequence_name7";
            this.label_sequence_name7.Size = new System.Drawing.Size(100, 19);
            this.label_sequence_name7.TabIndex = 3;
            this.label_sequence_name7.Text = "sequence name";
            this.label_sequence_name7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_sequence7
            // 
            this.label_sequence7.AutoSize = true;
            this.label_sequence7.Location = new System.Drawing.Point(127, 2);
            this.label_sequence7.Name = "label_sequence7";
            this.label_sequence7.Size = new System.Drawing.Size(502, 19);
            this.label_sequence7.TabIndex = 2;
            this.label_sequence7.Text = "0,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5|20,10-5     1.35ml     1min26s    " +
    " pump x";
            this.label_sequence7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_COM_flow
            // 
            this.label_COM_flow.AutoSize = true;
            this.label_COM_flow.Location = new System.Drawing.Point(547, 689);
            this.label_COM_flow.Name = "label_COM_flow";
            this.label_COM_flow.Size = new System.Drawing.Size(28, 19);
            this.label_COM_flow.TabIndex = 14;
            this.label_COM_flow.Text = "NA";
            this.label_COM_flow.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // checkBox_show_plot
            // 
            this.checkBox_show_plot.AutoSize = true;
            this.checkBox_show_plot.Location = new System.Drawing.Point(705, 689);
            this.checkBox_show_plot.Name = "checkBox_show_plot";
            this.checkBox_show_plot.Size = new System.Drawing.Size(75, 15);
            this.checkBox_show_plot.TabIndex = 15;
            this.checkBox_show_plot.Text = "show plot";
            this.checkBox_show_plot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_show_plot.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1291, 718);
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
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.button_start_wo_rec);
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
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown1)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton button_start;
        private MetroFramework.Controls.MetroButton button_stop;
        private MetroFramework.Controls.MetroButton button_start_wo_rec;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfPanelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private MetroFramework.Controls.MetroPanel panel_pump_panel1;
        private MetroFramework.Controls.MetroPanel panel_data_description;
        private MetroFramework.Controls.MetroLabel label_sequence1;
        private MetroFramework.Controls.MetroLabel label_sequence_name1;
        private MetroFramework.Controls.MetroCheckBox checkBox_sequence1;
        private MetroFramework.Controls.MetroPanel panel_pump_panel2;
        private MetroFramework.Controls.MetroCheckBox checkBox_sequence2;
        private MetroFramework.Controls.MetroLabel label_sequence_name2;
        private MetroFramework.Controls.MetroLabel label_sequence2;
        private MetroFramework.Controls.MetroPanel panel_pump_panel3;
        private MetroFramework.Controls.MetroCheckBox checkBox_sequence3;
        private MetroFramework.Controls.MetroLabel label_sequence_name3;
        private MetroFramework.Controls.MetroLabel label_sequence3;
        private MetroFramework.Controls.MetroPanel panel_pump_panel4;
        private MetroFramework.Controls.MetroCheckBox checkBox_sequence4;
        private MetroFramework.Controls.MetroLabel label_sequence_name4;
        private MetroFramework.Controls.MetroLabel label_sequence4;
        private MetroFramework.Controls.MetroPanel panel_pump_panel5;
        private MetroFramework.Controls.MetroCheckBox checkBox_sequence5;
        private MetroFramework.Controls.MetroLabel label_sequence_name5;
        private MetroFramework.Controls.MetroLabel label_sequence5;
        private MetroFramework.Controls.MetroPanel panel_pump_panel6;
        private MetroFramework.Controls.MetroCheckBox checkBox_sequence6;
        private MetroFramework.Controls.MetroLabel label_sequence_name6;
        private MetroFramework.Controls.MetroLabel label_sequence6;
        private MetroFramework.Controls.MetroPanel panel_pump_panel7;
        private MetroFramework.Controls.MetroCheckBox checkBox_sequence7;
        private MetroFramework.Controls.MetroLabel label_sequence_name7;
        private MetroFramework.Controls.MetroLabel label_sequence7;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_flow;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel label_COM_flow;
        private FlatNumericUpDown flatNumericUpDown1;
        public MetroFramework.Controls.MetroCheckBox checkBox_show_plot;
        public MetroFramework.Controls.MetroTextBox textBox_filename;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

