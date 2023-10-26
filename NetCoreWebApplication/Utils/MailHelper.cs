using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using System.Net.Mail;

namespace NetCoreWebApplication.Utils
{
    public class MailHelper
    {
        public static bool SendMail(Contact contact)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential("email_kullanici_adi@gmail.com", "email_sifre");
                smtpClient.EnableSsl = true;
                MailMessage message = new MailMessage();
                message.From = new MailAddress("alıcı@gmail.com");
                message.To.Add("mesajıngideceğiadres@gmail.com");//mesajın gideceği adres
                message.Subject = "Siteden mesaj var...";
                message.Body = $"<p>Mesaj Bilgileri: <hr/>İsim:{contact.Name}  <hr/>Email:{contact.Email}  <hr/>Telefon:{contact.Phone}  <hr/>Mesaj:{contact.Message} <hr/>Tarih:{contact.CreateDate}</p>";
                message.IsBodyHtml = true;
                smtpClient.Send(message);



                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }
    }
}
