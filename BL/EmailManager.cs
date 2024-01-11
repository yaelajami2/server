using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
     class EmailManager
    {
        public static void email_send(string email,string massege,string Subject)
        {
            string to = massege;
            MailMessage message = new MailMessage("tripyaeleden@gmail.com", email);
            message.Subject = Subject;
            message.Body = massege;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential("tripyaeleden@gmail.com", "anpckkcheirpwdbv");
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }
    }
}
