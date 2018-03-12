using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using EASendMail;

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
            bool cond = false;
            if (condition_combobox.SelectedIndex == 0)
            {
                var hs = new DownloadNodesSample.HtmlSample(url_textbox.Text);
                var file_link = hs.Find(word_textbox.Text);
                if (file_link == "")
                {
                    MessageBox.Show("Nie znaleziono takiego obrazka");
                    cond = false;
                }
                else
                {
                    cond = true;
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(file_link), "image.jpg");
                    }
                }
            }

            if (action_combobox.SelectedIndex == 0 && cond == true)
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                SmtpClient oSmtp = new SmtpClient();

                // Your gmail email address
                oMail.From = "cssender44@gmail.com";

                // Set recipient email address
                oMail.To = email_textbox.Text;

                // Set email subject
                oMail.Subject = "Nowy obrazek";
                oMail.AddAttachment("image.jpg");

                // Set email body
                oMail.TextBody = "Nowy obrazek w załączniku";
                // Gmail SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                // Set 465 port
                oServer.Port = 465;

                // detect SSL/TLS automatically
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                // Gmail user authentication
                // For example: your email is "gmailid@gmail.com", then the user should be the same
                oServer.User = "cssender44@gmail.com";
                oServer.Password = "dotnet44";

                
                oSmtp.SendMail(oServer, oMail);

                MessageBox.Show("Prawdopodobnie wysłano :)");
         

            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
namespace DownloadNodesSample
{
    public class HtmlSample
    {
        private readonly string _url;

        public HtmlSample(string url)
        {
            this._url = url;
        }

        /// <summary>
        /// Prosta metoda, która zwraca zawartość HTML podanej strony www
        /// </summary>
        public string GetPageHtml()
        {
            using (var wc = new WebClient())
            {
                // Ustawiamy prawidłowe kodowanie dla tej strony
                wc.Encoding = Encoding.UTF8;
                // Dekodujemy HTML do czytelnych dla wszystkich znaków 
                var html = System.Net.WebUtility.HtmlDecode(wc.DownloadString(_url));

                return html;
            }
        }

        /// <summary>
        /// Równie prosta metoda, która wypisuje na konsole wartości atrybutów src oraz alt taga IMG
        /// znajdujących się na podanej stronie www
        /// </summary>
        public string Find(string myword)
        {
            // Tworzymy obiekt klasy HtmlDocument zdefiniowanej w namespace HtmlAgilityPack
            // Uwaga - w referencjach projektu musi się znajdować ta biblioteka
            // Przy użyciu nuget-a pojawi się tam automatycznie
            var doc = new HtmlAgilityPack.HtmlDocument();

            // Używamy naszej metody do pobrania zawartości strony
            var pageHtml = GetPageHtml();

            // Ładujemy zawartość strony html do struktury documentu (obiektu klasy HtmlDocument)
            doc.LoadHtml(pageHtml);

            // Metoda Descendants pozwala wybrać zestaw node'ów o określonej nazwie
            var nodes = doc.DocumentNode.Descendants("img");
            string a = "";
            // Iterujemy po wszystkich znalezionych node'ach
            foreach (var node in nodes)
            {

               
                if (node.GetAttributeValue("alt", "").Contains(myword))
                {
                    a = node.GetAttributeValue("src", "").ToString();
                    break;
                   
                }
            }
            return a;

        }
    }
}
