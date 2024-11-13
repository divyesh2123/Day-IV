using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Day_IV
{
    public class EmailNotification
    {
        public bool SendEmail(
            string bodyContent,
            string title,
            string toEmail)
        {

            var to = new MailAddress(toEmail);
            var from = new MailAddress("divyesh.weltec@gmail.com");
            const string fromPassword = "xric uqge ifga piql";
            var smtp = new SmtpClient
            {
                Host=   "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,    
                UseDefaultCredentials =false,
                Credentials = new NetworkCredential(from.Address, fromPassword)
            };

            var message = new MailMessage(from, to);
            message.Subject = title;
            message.Body = bodyContent;

            smtp.Send(message); 





            return true;
        }

        public bool SendEmail(
           string[] email,
           string bodyContent,
           string toEmail)
        {
            return true;
        }
    }
}
