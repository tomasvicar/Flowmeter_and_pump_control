using System;
using System.IO.Ports;
using prutokomer_a_pumpa;
using System.Threading;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

public class Flowmeter
{
    private SerialPort serialPort;
    private Form1 form;
    private CultureInfo enUS = new CultureInfo("en-US");
    //private decimal maxShowSamples = 600;
    private decimal maxShowSamples = 800;
    private decimal period = 0.05m;
    private decimal t;
    public bool recording = false;
    private StreamWriter textfile;
    private string header;

    public Flowmeter(Form1 form)
	{
        this.form = form;
    }

    public void openFlowSerial()
    {
        form.label_COM_flow.Text = "Connecting";
        form.label_COM_flow.ForeColor = System.Drawing.Color.Gray;

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
                serialPort = new SerialPort(port, 115200);

                serialPort.Open();
                serialPort.WriteTimeout = 1000;
                serialPort.ReadTimeout = 1000;

                Thread.Sleep(100);
                string message1 = serialPort.ReadLine();


                Console.WriteLine(message1);

                if (message1.StartsWith("F"))
                {
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerFlow);
                    form.label_COM_flow.Text = port;
                    form.label_COM_flow.ForeColor = System.Drawing.Color.Green;

                    //string indata = serialPort.ReadLine();
                    //Console.WriteLine(indata);

                    return;
                }
                else
                {
                    serialPort.Close();

                }

            }
            catch (TimeoutException)
            {
                Console.WriteLine("time out");
                serialPort.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                serialPort.Close();
            }
        }
        form.label_COM_flow.Text = "NA";
        form.label_COM_flow.ForeColor = System.Drawing.Color.Red;

    }
    private void DataReceivedHandlerFlow(object sender, SerialDataReceivedEventArgs e)
    {
        try
        {
            SerialPort sp = (SerialPort)sender;
            //string indata = sp.ReadExisting();

            string indata = sp.ReadLine().Substring(1).Trim();


            if (form.checkBox_showPlot.Checked)
            {
                decimal data = Convert.ToDecimal(indata, enUS);

                t = t + period;

                form.chart_flow.BeginInvoke((MethodInvoker)delegate
                {
                    form.chart_flow.Series[0].Points.AddXY(t, data);
                    if (form.chart_flow.Series[0].Points.Count > maxShowSamples)
                    {
                        form.chart_flow.Series[0].Points.RemoveAt(0);

                    }
                    form.chart_flow.ChartAreas[0].RecalculateAxesScale();
                });
            }



            if (recording)
            {
                if (textfile.BaseStream != null)
                {
                    string to_write = DateTime.Now.ToString("HH:mm:ss.fff");
                    to_write += ";" + indata + "\n";
                    textfile.Write(to_write);
                    //Console.Write(to_write);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());

        }

    }

    public void startTextFile()
    {
        DateTime time = DateTime.Now;
        CultureInfo csCZ = CultureInfo.GetCultureInfo("cs-CZ");
        string filename = Path.Combine(form.textBox_filename.Text + '_' + time.ToString(csCZ).Replace(".", "_").Replace(":", "_").Replace(" ", "_") + ".txt");

        textfile = new StreamWriter(filename);

        string header2 = get_header_2();

        textfile.Write(header2);

        textfile.Write(header);

        textfile.Write("###header_end###\n");

        recording = true;

        



    }

    private string get_header_2()
    {


        string header_2 = "";
        header_2 += "experiment_number " + form.numericUpDown_number.Value.ToString("00") + "\n";
        header_2 += "experiment " + form.textBox_experiment.Text + "\n";
        header_2 += "WP " + form.numericUpDown_WP.Value.ToString("0") + "\n";
        header_2 += "well " + form.numericUpDown_well.Value.ToString("0") + "\n";
        header_2 += "FOV " + form.numericUpDown_FOV.Value.ToString("0") + "\n";
        header_2 += "cells " + form.textBox_cells.Text + "\n";

        header_2 += "well_position " + form.textBox_well_position.Text + "\n";
        header_2 += "date_seeded " + form.maskedTextBox_date_seeded.Text + "\n";
        header_2 += "note " + form.textBox_note.Text + "\n";


        return header_2;
    }
    public void closeTextfile()
    {
        textfile.Close();
    }
    public void resetTime()
    {
        t = 0m;
    }
}
