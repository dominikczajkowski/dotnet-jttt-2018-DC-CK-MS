using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingList<Task.task> tasks = new BindingList<Task.task>();
            listBox1.DataSource = tasks;
            tasks.Add(new Task.task(email_textbox.Text, word_textbox.Text, url_textbox.Text, Task_name_textbox.Text));
           // tasks.ElementAt(0).GetAndSend();
        }

    }
}


