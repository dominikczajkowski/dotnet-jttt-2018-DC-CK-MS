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
            //var t = new Task.task();
            //t.email = email_textbox.Text;
            //t.word = word_textbox.Text;
            //t.url = url_textbox.Text;
            //t.task_name = Task_name_textbox.Text;

            tasks.Add(new Task.task(email_textbox.Text,word_textbox.Text,url_textbox.Text,Task_name_textbox.Text));
           // tasks.ElementAt(0).GetAndSend();
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
    }
}


