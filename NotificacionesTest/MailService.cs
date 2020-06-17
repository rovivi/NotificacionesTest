using NotificacionesTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificacionesTest
{
    public class MailService
    {

        public static void SendMail(Mail mail)
        {

            if (mail.Title == "error")
                throw new Exception();




        }

    }
}
