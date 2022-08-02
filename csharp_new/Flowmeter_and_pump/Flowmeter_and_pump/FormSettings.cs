using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowmeter_and_pump
{
    public partial class FormSettings : MetroForm
    {
        private Form1 form;
        public FormSettings(Form1 form)
        {
            this.form = form;
            InitializeComponent();

            this.numericUpDown_num_of_seq.Value = form.numericUpDown_num_of_seq.Value;
            this.textBox_pa_is_xx_ml_min.Text = form.textBox_pa_is_xx_ml_min.Text;
            this.textBox_time_reserve_s.Text = form.textBox_time_reserve_s.Text;
            this.textBox_diameter.Text = form.textBox_diameter.Text;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            form.numericUpDown_num_of_seq.Value = this.numericUpDown_num_of_seq.Value;
            form.textBox_pa_is_xx_ml_min.Text = this.textBox_pa_is_xx_ml_min.Text;
            form.textBox_time_reserve_s.Text = this.textBox_time_reserve_s.Text;
            form.textBox_diameter.Text = this.textBox_diameter.Text;
            this.Close();
        }
    }
}
