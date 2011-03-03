namespace ESDS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net.Mail;
    using System.Net;
    using System.Configuration;

    class SubscriptionMailer
    {

        const string subject = "automatic restate mailer";
        const string body = "Hey you, I am sent form .net console. If you see this, we can send emails. muahahaaaa";
        MailAddress fromAddress;
        MailAddress toAddress;
        string fromPassword;

        public SubscriptionMailer()
        {
            fromAddress = new MailAddress("restatemailer@gmail.com ", "Automatic mailer");
            toAddress = new MailAddress("ce903-group2@googlegroups.com", "Best group ever");
            fromPassword = ConfigurationManager.AppSettings["mailpwd"];
        }

        public void Deliver()
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };

            using (
                var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                }
            ){
                smtp.Send(message);
            }
        }
    }
}
