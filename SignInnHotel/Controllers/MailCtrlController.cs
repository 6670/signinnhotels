using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SignInnHotel.Controllers
{
    public class MailCtrlController : Controller
    {
        // GET: MailCtrl
        public ActionResult Index()
        {
            MailMessage mail = new MailMessage("noreplay@signinnhotels.com", "developer6670@gmail.com");
            SmtpClient client = new SmtpClient("mail.signinnhotels.com",25);
           // client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("noreplay@signinnhotels.com", "Noreplay@123");
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            client.Send(mail);
            return View();
        }
        public ActionResult Index2()
        {
            MailMessage mail = new MailMessage("info@signinnhotels.com", "developer6670@gmail.com");
            SmtpClient client = new SmtpClient("webmail.signinnhotels.com", 443);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("info@signinnhotels.com", "Info@123");
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            client.Send(mail);
            return View();
        }
    }
}