
namespace Flowmeter_and_pump
{
    partial class FormSequence
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
            this.texBox_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox_sequence = new MetroFramework.Controls.MetroTextBox();
            this.button_ok = new MetroFramework.Controls.MetroButton();
            this.numericUpDown_number = new FlatNumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number)).BeginInit();
            this.SuspendLayout();
            // 
            // texBox_name
            // 
            // 
            // 
            // 
            this.texBox_name.CustomButton.Image = null;
            this.texBox_name.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.texBox_name.CustomButton.Name = "";
            this.texBox_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.texBox_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.texBox_name.CustomButton.TabIndex = 1;
            this.texBox_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.texBox_name.CustomButton.UseSelectable = true;
            this.texBox_name.CustomButton.Visible = false;
            this.texBox_name.Lines = new string[] {
        "texBox_name"};
            this.texBox_name.Location = new System.Drawing.Point(23, 41);
            this.texBox_name.MaxLength = 32767;
            this.texBox_name.Name = "texBox_name";
            this.texBox_name.PasswordChar = '\0';
            this.texBox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.texBox_name.SelectedText = "";
            this.texBox_name.SelectionLength = 0;
            this.texBox_name.SelectionStart = 0;
            this.texBox_name.ShortcutsEnabled = true;
            this.texBox_name.Size = new System.Drawing.Size(200, 23);
            this.texBox_name.TabIndex = 0;
            this.texBox_name.Text = "texBox_name";
            this.texBox_name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.texBox_name.UseSelectable = true;
            this.texBox_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.texBox_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "sequence name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(264, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "sequence       delay,time-Pa|delay,time-Pa|...";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox_sequence
            // 
            // 
            // 
            // 
            this.textBox_sequence.CustomButton.Image = null;
            this.textBox_sequence.CustomButton.Location = new System.Drawing.Point(612, 1);
            this.textBox_sequence.CustomButton.Name = "";
            this.textBox_sequence.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_sequence.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_sequence.CustomButton.TabIndex = 1;
            this.textBox_sequence.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_sequence.CustomButton.UseSelectable = true;
            this.textBox_sequence.CustomButton.Visible = false;
            this.textBox_sequence.Lines = new string[] {
        "textBox_sequence"};
            this.textBox_sequence.Location = new System.Drawing.Point(23, 110);
            this.textBox_sequence.MaxLength = 32767;
            this.textBox_sequence.Name = "textBox_sequence";
            this.textBox_sequence.PasswordChar = '\0';
            this.textBox_sequence.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_sequence.SelectedText = "";
            this.textBox_sequence.SelectionLength = 0;
            this.textBox_sequence.SelectionStart = 0;
            this.textBox_sequence.ShortcutsEnabled = true;
            this.textBox_sequence.Size = new System.Drawing.Size(634, 23);
            this.textBox_sequence.TabIndex = 2;
            this.textBox_sequence.Text = "textBox_sequence";
            this.textBox_sequence.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox_sequence.UseSelectable = true;
            this.textBox_sequence.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_sequence.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_sequence.Click += new System.EventHandler(this.textBox_sequence_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(234, 139);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(109, 44);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "OK";
            this.button_ok.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_ok.UseSelectable = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // numericUpDown_number
            // 
            this.numericUpDown_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numericUpDown_number.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_number.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_number.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numericUpDown_number.Location = new System.Drawing.Point(419, 44);
            this.numericUpDown_number.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_number.Name = "numericUpDown_number";
            this.numericUpDown_number.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_number.TabIndex = 5;
            this.numericUpDown_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(393, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "pump number";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FormSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 195);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.numericUpDown_number);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textBox_sequence);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.texBox_name);
            this.Name = "FormSequence";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormSequence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox texBox_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBox_sequence;
        private MetroFramework.Controls.MetroButton button_ok;
        public FlatNumericUpDown numericUpDown_number;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}