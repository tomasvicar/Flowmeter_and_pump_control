using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowmeter_and_pump
{
    class Timer
    {
        private DateTime startTime;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private float req_time;// !!!!!!!!!!!!!!!!!!!!!!!!
        public Form1 form;

        public Timer(Form1 form)
        {
            this.form = form;
        }

        public void startTimer()
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
            form.label_timer.Text = diff.Minutes.ToString() + "min " + diff.Seconds.ToString() + "s" + " / " + Math.Floor(req_time / 60).ToString("0") + "min " + (req_time % 60).ToString("0") + "s";


            if ((diff.Minutes * 60 + diff.Seconds) > req_time)
            {
                if (form.button_stop.Enabled)
                {
                    Console.WriteLine("stop klick ");
                    form.button_stop.PerformClick();
                }
                if (form.button_stop_without_recording.Enabled)
                {
                    Console.WriteLine("stop click2");
                    form.button_stop_without_recording.PerformClick();
                }
            }


        }
        public void stop()
        {
            timer.Stop();
            form.label_timer.Text = "timer";
        }

    }
}
