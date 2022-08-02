using MetroFramework.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Flowmeter_and_pump
{
    class Saver
    {
        public Form1 form;
        private ArrayList to_save = new ArrayList();
        public Saver(Form1 form)
        {
            this.form = form;
        }


        public void get_objects_to_save()
        {
            foreach (Control obj in form.Controls)
            {
                //if ((obj.GetType() == typeof(FlatNumericUpDown)) | (obj.GetType() == typeof(MetroLabel)) | (obj.GetType() == typeof(MetroTextBox)) | (obj.GetType() == typeof(MetroCheckBox)))
                //    to_save.Add(obj);
                if (obj.GetType() == typeof(MetroPanel))
                {
                    foreach (var obj2 in obj.Controls)
                    {
                        if ((obj2.GetType() == typeof(FlatNumericUpDown)) | (obj2.GetType() == typeof(MetroLabel)) | (obj2.GetType() == typeof(MetroTextBox)) | (obj2.GetType() == typeof(MetroCheckBox)))
                            to_save.Add(obj2);
                    }
                }
            }
        }
        public void save()
        {
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.FileName = "settings.json";
            mySaveFileDialog.InitialDirectory = ".";
            mySaveFileDialog.Filter = "JSON|*.json";
            if (!(mySaveFileDialog.ShowDialog() == DialogResult.OK))
            {
                return;
            }

            Dictionary<string, object> _data = new Dictionary<string, object>();

            foreach (object obj in to_save)
            {
                if (obj.GetType() == typeof(FlatNumericUpDown))
                {
                    FlatNumericUpDown obj_converted = (FlatNumericUpDown)Convert.ChangeType(obj, typeof(FlatNumericUpDown));
                    _data.Add(obj_converted.Name, obj_converted.Value);
                }
                if (obj.GetType() == typeof(MetroLabel))
                {
                    MetroLabel obj_converted = (MetroLabel)Convert.ChangeType(obj, typeof(MetroLabel));
                    _data.Add(obj_converted.Name, obj_converted.Text);
                }
                if (obj.GetType() == typeof(MetroTextBox))
                {
                    MetroTextBox obj_converted = (MetroTextBox)Convert.ChangeType(obj, typeof(MetroTextBox));
                    _data.Add(obj_converted.Name, obj_converted.Text);
                }
                if (obj.GetType() == typeof(MetroCheckBox))
                {
                    MetroCheckBox obj_converted = (MetroCheckBox)Convert.ChangeType(obj, typeof(MetroCheckBox));
                    _data.Add(obj_converted.Name, obj_converted.Enabled);
                }
            }


            string json = JsonConvert.SerializeObject(_data);
            File.WriteAllText(mySaveFileDialog.FileName, json);
        }
        public void load()
        {

            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            myOpenFileDialog.FileName = "settings.json";
            myOpenFileDialog.InitialDirectory = ".";
            myOpenFileDialog.Filter = "JSON|*.json";
            if (!(myOpenFileDialog.ShowDialog() == DialogResult.OK))
            {
                return;
            }

            string json_loaded = File.ReadAllText(myOpenFileDialog.FileName);
            Dictionary<string, object> _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(json_loaded);

            for (int i = 0; i < to_save.Count; i++)
            {
                object obj = to_save[i];
                if (obj.GetType() == typeof(FlatNumericUpDown))
                {
                    FlatNumericUpDown obj_converted = (FlatNumericUpDown)Convert.ChangeType(obj, typeof(FlatNumericUpDown));
                    obj_converted.Value = (decimal)Convert.ChangeType(_data.ElementAt(i).Value, typeof(decimal));
                }
                if (obj.GetType() == typeof(MetroLabel))
                {
                    MetroLabel obj_converted = (MetroLabel)Convert.ChangeType(obj, typeof(MetroLabel));
                    obj_converted.Text = (string)Convert.ChangeType(_data.ElementAt(i).Value, typeof(string));
                }
                if (obj.GetType() == typeof(MetroTextBox))
                {
                    MetroTextBox obj_converted = (MetroTextBox)Convert.ChangeType(obj, typeof(MetroTextBox));
                    obj_converted.Text = (string)Convert.ChangeType(_data.ElementAt(i).Value, typeof(string));
                }
                if (obj.GetType() == typeof(MetroCheckBox))
                {
                    MetroCheckBox obj_converted = (MetroCheckBox)Convert.ChangeType(obj, typeof(MetroCheckBox));
                    obj_converted.Enabled = (bool)Convert.ChangeType(_data.ElementAt(i).Value, typeof(bool));
                }
            }
        }



    }
}
