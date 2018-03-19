using System;
using System.Windows.Forms;
using System.Net;
using EASendMail;
namespace Task
{
    class task
    {
        string email = "";
        string word = "";
        string url = "";
        string task_name = "";
        private string image = "image.jpg";
        
        public task(string Email, string Word, string Url, string Task)
        {
            email = Email;
            word = Word;
            url = Url;
            task_name = Task;
        }

        public void GetAndSend()
        {
            bool cond = false;

                var hs = new DownloadNodesSample.HtmlSample(url);
                var file_link = hs.Find(word);
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
                        client.DownloadFile(new Uri(file_link), image);
                    }
                }
            

            if (cond == true)
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                SmtpClient oSmtp = new SmtpClient();

                // Your gmail email address
                oMail.From = "cssender44@gmail.com";

                // Set recipient email address
                oMail.To = email;

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
        public override string ToString()
        {
            return "Task name:"+task_name+" Url:"+url+" Email:"+email+" Szukane słowo:"+word;
        }
    }
    }

