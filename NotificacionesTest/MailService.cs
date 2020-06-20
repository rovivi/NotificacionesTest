using NotificacionesTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace NotificacionesTest
{
    public class MailService
    {

        public static void SendMail(Mail mail)
        {
            MailMessage message = new MailMessage(mail.From==null? "kyagamypump1@gmail.com":mail.From, mail.To);
            SmtpClient client = new SmtpClient(mail.Host ?? "smtp.gmail.com", mail.Port ?? 587);

            message.Body = mail.Body;
            message.Subject = mail.Title;
            client.UseDefaultCredentials = mail.DefaultCredentiasl ?? false;
            client.EnableSsl = mail.UseSSL ?? true;

            #region 

            client.Credentials = new System.Net.NetworkCredential("USER@gmail.com", "pass");
            #endregion 

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }

    public class EmailConfiguration
    {
        public string From { get; set; }
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
