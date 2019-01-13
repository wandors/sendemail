using System.Net;
using System.Net.Mail;

namespace sendemail
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Отправка письма с вложениям ччерез gmail почту средствами с№**/
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("srpolunec@gmail.com");
            mail.To.Add("polunec@ukr.net");
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail with attachment";
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("d:/textfile.txt");
            mail.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("srpolunec@gmail.com", "sr250384");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
