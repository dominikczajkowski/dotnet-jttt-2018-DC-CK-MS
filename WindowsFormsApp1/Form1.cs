using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using OpenWeatherMap;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        BindingList<Task.task> tasks = new BindingList<Task.task>();
        public Form1()
        {
            InitializeComponent();
            listBox1.HorizontalScrollbar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.DataSource = tasks;
            using (var db = new Task.TaskDbContext())
            {
                db.Tasks.Add(new Task.task(email_textbox.Text, word_textbox.Text, url_textbox.Text, Task_name_textbox.Text));
                db.SaveChanges();
                foreach( var t in db.Tasks)
                {
                    tasks.Add(new Task.task(t.email, t.word, t.url, t.Id));
                }
            }

            //  tasks.Add(new Task.task(email_textbox.Text, word_textbox.Text, url_textbox.Text, Task_name_textbox.Text));

        }

        private void exec_button_Click(object sender, EventArgs e)
        {
            foreach(var i in tasks)
            {
                i.GetAndSend();
            }
        }

        private void cln_button_Click(object sender, EventArgs e)
        {
            tasks.Clear();

        }

        private void serial_button_Click(object sender, EventArgs e)
        {
            if (File.Exists("storage"))
            {
                File.Delete("storage");
            }
            FileStream stream = File.Create("storage");
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, tasks);
            stream.Close();
        }

        private void deserial_Click(object sender, EventArgs e)
        {
            var stream = File.OpenRead("storage");
            var formatter = new BinaryFormatter();
            tasks = (BindingList<Task.task>)formatter.Deserialize(stream);
            stream.Close();
            listBox1.DataSource = tasks;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void weatherbtt_Click(object sender, EventArgs e)
        {
                        string key = "88bfb0ad9a9e936ff6a817e9729086cd";
            OpenWeatherMap.Standard.Forecast forecast = new OpenWeatherMap.Standard.Forecast();
             OpenWeatherMap.Standard.WeatherData dataCity = null;
            System.Threading.Tasks.Task getWeatherCity = System.Threading.Tasks.Task.Run(async () => { dataCity = await forecast.GetWeatherDataByCityNameAsync(key, cityInput.Text,"pl", OpenWeatherMap.Standard.WeatherUnits.metric); });
                         getWeatherCity.Wait();
  
            MessageBox.Show("Temp:"+dataCity.main.temp.ToString()+" Ciśnienie:"+dataCity.main.pressure.ToString()+"hPa "+"Niebo:"+dataCity.weather[0].description);

            
        }
    }
}


