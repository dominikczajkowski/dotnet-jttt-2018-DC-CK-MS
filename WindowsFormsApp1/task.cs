﻿using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
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
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("cssender44@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Nowy obrazek";
                mail.Body = "Nowy obrazek w załączniku";
                mail.Attachments.Add(new Attachment(image));

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("cssender44@gmail.com", "dotnet44");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);


                MessageBox.Show("Prawdopodobnie wysłano :)");


            }
           


        }
        public override string ToString()
        {
            return "Task name:"+task_name+" Url:"+url+" Email:"+email+" Szukane słowo:"+word;
        }
    }
    }

