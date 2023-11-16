using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Globalization;

namespace Flowmeter_and_pump
{
    public interface ISerialPort : IDisposable
    {
        void Open();
        void Close();
        bool IsOpen { get; }
        int DataBits { get; set; }
        Parity Parity { get; set; }
        StopBits StopBits { get; set; }
        string NewLine { get; set; }
        int WriteTimeout { get; set; }
        int ReadTimeout { get; set; }
        void WriteLine(string text);
        string ReadLine();
        event SerialDataReceivedEventHandler DataReceived;
    }

    public class SerialPortAdapter : ISerialPort
    {
        private SerialPort _serialPort;

        public SerialPortAdapter(string portName, int baudRate)
        {
            _serialPort = new SerialPort(portName, baudRate);
            // Initialize other necessary properties of _serialPort
        }

        public void Open() => _serialPort.Open();
        public void Close() => _serialPort.Close();
        public bool IsOpen => _serialPort.IsOpen;
        public int DataBits { get => _serialPort.DataBits; set => _serialPort.DataBits = value; }
        public Parity Parity { get => _serialPort.Parity; set => _serialPort.Parity = value; }
        public StopBits StopBits { get => _serialPort.StopBits; set => _serialPort.StopBits = value; }
        public string NewLine { get => _serialPort.NewLine; set => _serialPort.NewLine = value; }
        public int WriteTimeout { get => _serialPort.WriteTimeout; set => _serialPort.WriteTimeout = value; }
        public int ReadTimeout { get => _serialPort.ReadTimeout; set => _serialPort.ReadTimeout = value; }
        public void WriteLine(string text) => _serialPort.WriteLine(text);
        public string ReadLine() => _serialPort.ReadLine();
        public event SerialDataReceivedEventHandler DataReceived
        {
            add { _serialPort.DataReceived += value; }
            remove { _serialPort.DataReceived -= value; }
        }

        public void Dispose()
        {
            _serialPort?.Dispose();
        }

    }


    public class VirtualSerialPort : ISerialPort
    {
        private SerialPort _serialPort;
        private float diameter;
        private List<float> volumes = new List<float>();
        private List<float> rates = new List<float>();
        private List<float> delays = new List<float>();
        private List<(int Delay, float Rate, int Time)> operationSequence = new List<(int, float, int)>();
        private List<(int Time, float Rate)> operationSequence2 = new List<(int, float)>();

        private int timer_index_in_pulse;



        private System.Windows.Forms.Timer _timer;

        public VirtualSerialPort(string portName, int baudRate)
        {
            _serialPort = new SerialPort(portName, baudRate);
            // Initialize other necessary properties of _serialPort
        }

        public void Open() => _serialPort.Open();
        public void Close() => _serialPort.Close();
        public bool IsOpen => _serialPort.IsOpen;
        public int DataBits { get => _serialPort.DataBits; set => _serialPort.DataBits = value; }
        public Parity Parity { get => _serialPort.Parity; set => _serialPort.Parity = value; }
        public StopBits StopBits { get => _serialPort.StopBits; set => _serialPort.StopBits = value; }
        public string NewLine { get => _serialPort.NewLine; set => _serialPort.NewLine = value; }
        public int WriteTimeout { get => _serialPort.WriteTimeout; set => _serialPort.WriteTimeout = value; }
        public int ReadTimeout { get => _serialPort.ReadTimeout; set => _serialPort.ReadTimeout = value; }
        public void WriteLine(string text) => MyWriteLine(text);

        public string ReadLine() => MyReadLine();
        //public string Read() => _serialPort.Read();



        public event SerialDataReceivedEventHandler DataReceived
        {
            add { _serialPort.DataReceived += value; }
            remove { _serialPort.DataReceived -= value; }
        }

        public void Dispose()
        {
            _serialPort?.Dispose();
        }

        private string MyReadLine()
        {
            String text = _serialPort.ReadLine();
            return text;
        }


        private void MyWriteLine(string text)
        {
            if (text.StartsWith("1 set diameter"))
            {
                // Expecting text in the form "1 set diameter 20"
                string[] splitText = text.Split(' ');
                if (splitText.Length == 4 && float.TryParse(splitText[3], out float parsedDiameter))
                {
                    diameter = parsedDiameter;
                }
            }
            else if (text.StartsWith("1 set volume"))
            {
                // Expecting text in the form "1 set volume 0.11,0.11,0.11,..."
                string[] splitText = text.Split(' ');
                if (splitText.Length == 4)
                {
                    string[] volumeStrings = splitText[3].Split(',');
                    volumes = volumeStrings.Select(v => float.TryParse(v, NumberStyles.Float, CultureInfo.InvariantCulture, out float vol) ? vol : 0f).ToList();
                }
            }
            else if (text.StartsWith("1 set rate"))
            {
                // Expecting text in the form "1 set rate 0.65,0.65,0.65,..."
                string[] splitText = text.Split(' ');
                if (splitText.Length == 4)
                {
                    string[] rateStrings = splitText[3].Split(',');
                    rates = rateStrings.Select(r => float.TryParse(r, NumberStyles.Float, CultureInfo.InvariantCulture, out float rate) ? rate : 0f).ToList();
                }
            }
            else if (text.StartsWith("1 set delay"))
            {
                string[] splitText = text.Split(' ');
                if (splitText.Length == 4)
                {
                    string[] delayStrings = splitText[3].Split(',');
                    delays = delayStrings.Select(r => float.Parse(r)).ToList();
                }
            }

            else if (text.StartsWith("1 start"))
            {
                operationSequence.Clear();
                // Assuming volumes and rates are in sync and the length is the same.
                for (int i = 0; i < volumes.Count; i++)
                {
                    // Calculate time in milliseconds for each volume/rate pair
                    int timeForVolume = (int)((volumes[i] / rates[i]) * 60); // Convert rate to mL/min and calculate time
                    operationSequence.Add(((int)delays[i], rates[i], timeForVolume));
                }
                StartOperation();


            }
            else if (text.StartsWith("1 pause"))
            {
                try {
                    _timer.Stop();
                }
                catch
                { 
                
                }
                _serialPort.WriteLine("0");

            }
            else
            {
                _serialPort.WriteLine(text);
            }
        }

        //private async Task StartOperationAsync()
        //{
        //    foreach (var (Delay, Rate, Time) in operationSequence)
        //    {

        //        // Simulate sending a command to set the rate
        //        Console.WriteLine("- t3000");
        //        _serialPort.WriteLine("t3000");

        //        // Delay
        //        await Task.Delay(Delay * 1000);

        //        // Simulate sending a start command
        //        Console.WriteLine("- >");
        //        _serialPort.WriteLine(">");

        //        // Operate for the calculated time
        //        await Task.Delay(Time * 1000);

        //        // Simulate sending a stop command
        //        Console.WriteLine("- 0");
        //        _serialPort.WriteLine("0");
        //    }
        //}

        private void StartOperation()
        {
            operationSequence2.Clear();
            timer_index_in_pulse = 0;
            foreach (var (Delay, Rate, Time) in operationSequence)
            {
                operationSequence2.Add((Delay, 0f));
                operationSequence2.Add((Time, Rate));
            }
            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += new EventHandler(timer_Tick);
            timer_Tick(null, EventArgs.Empty);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int tmp_time = 0;
            float tmp_rate = 0;
            while (tmp_time == 0)
            {
                (int Time, float Rate) pair = operationSequence2[timer_index_in_pulse];
                timer_index_in_pulse++;
                Console.WriteLine("timer_index_in_pulse:");
                Console.WriteLine(timer_index_in_pulse);
                tmp_time = pair.Time;
                tmp_rate = pair.Rate;
                if (timer_index_in_pulse >= operationSequence2.Count)
                {
                    _timer.Stop();
                    _serialPort.WriteLine("0");
                    _timer.Tick -= new EventHandler(timer_Tick);
                    break;
                }

            }

            Console.WriteLine("rate:");
            Console.WriteLine(tmp_rate);
            if (tmp_rate == 0)
            {
                Console.WriteLine("- 0");
                _serialPort.WriteLine("0");
            }
            else {

                int t_us_puls = (int)((2 * Math.PI * Math.Pow(10, 2) * 60) / (tmp_rate * 6400) * Math.Pow(10, 6) * 2 );
                Console.WriteLine("- q" + t_us_puls.ToString());
                _serialPort.WriteLine("q" + t_us_puls.ToString());
            }
            _timer.Interval = tmp_time * 1000;
            if (!_timer.Enabled)
            {
                _timer.Start();
            }

        }
    }


}


//1 status
//0
//> 1 set units 0
//Invalid Command!
//> 1 set diameter 20
//Invalid Command!
//> 1 set volume 0.11,0.11,0.11,0.11,0.11,0.11,0.11
//Invalid Command!
//> 1 set rate 0.65,0.65,0.65,0.65,0.65,0.65,0.65
//Invalid Command!
//> 1 start 1 
//Invalid Command!
//> 1 pause 
//Invalid Command!
//>1 set units 0
//units = 0
//>1 set diameter 20
//diameter = 20.000
//>1 set volume 0.11,0.11,0.11,0.11,0.11,0.11,0.11
//volume = 0.110000,0.110000,0.110000,0.110000,0.110000,0.110000,0.110000
//>1 set rate 0.65,0.65,0.65,0.65,0.65,0.65,0.65
//rate = 0.650000,0.650000,0.650000,0.650000,0.650000,0.650000,0.650000
//>1 start 1 
//Pump start running...
//>1 pause 
//Pump stop!