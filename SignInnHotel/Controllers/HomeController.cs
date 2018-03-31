using SignInnHotel.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SignInnHotel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [WhitespaceFilter]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RoomBookingFormModel model)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage("noreply@signinnhotels.com", "developer6670@gmail.com");
                SmtpClient client = new SmtpClient("mail.signinnhotels.com", 25);
                // client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("noreply@signinnhotels.com", "Noreply@123");
                mail.Subject = "Book My Hotel";
                mail.Body = CraeteMailBody(model);
                try
                {
                    client.Send(mail);

                    sendConfirmtoCustomer(model);
                }catch (Exception ex)
                {

                }
         
            }
            return View();
        }

        private void sendConfirmtoCustomer(RoomBookingFormModel model)
        {
            MailMessage mail = new MailMessage("noreply@signinnhotels.com", model.CustomerEmail);
            SmtpClient client = new SmtpClient("mail.signinnhotels.com", 25);
            // client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("noreply@signinnhotels.com", "Noreply@123");
            mail.Subject = "Book My Hotel";
            mail.Body = CraeteCustomerMailBody(model);
            try
            {
                client.Send(mail); 
            }
            catch(Exception ex)
            {

            }
        }

        private string CraeteMailBody(RoomBookingFormModel model)
        {
            string strEmailBody = "";
            strEmailBody += "Inquery Time: ";
            strEmailBody += model.InqueryTime;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Customer Email: ";
            strEmailBody += model.CustomerEmail;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Customer Phone: ";
            strEmailBody += model.CustomerPhone;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Arivel Time: ";
            strEmailBody += model.CustomerArivalTime;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Departure Time: ";
            strEmailBody += model.CustomerDepartureTime;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Total Guests: ";
            strEmailBody += model.TotalGuests;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            return strEmailBody;
        }

        private string CraeteCustomerMailBody(RoomBookingFormModel model)
        {
            string strEmailBody = "";
            strEmailBody += "Inquery Time: ";
            strEmailBody += model.InqueryTime;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Your Email: ";
            strEmailBody += model.CustomerEmail;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Your Phone: ";
            strEmailBody += model.CustomerPhone;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;



            strEmailBody += ".................................................................";
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Thank You, Your Request has been successfully sent.";
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Sign Inn Hotel";
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "Lake Side-6, Baidam Road, Pokhara, Nepal";
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;
            strEmailBody += "Lake Side-6, Baidam Road, Pokhara, Nepal";
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;

            strEmailBody += "+977 61 461496";
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;
            strEmailBody += "+977 9869724085";
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;
            strEmailBody += "www.signinnhotels.com";
            strEmailBody = strEmailBody + Environment.NewLine + Environment.NewLine;
            strEmailBody += "More Info : mail to info@signinnhotels.com";


            return strEmailBody;
        }

        [WhitespaceFilter]
        public ActionResult AboutUs()
        {
            return View();
        }
        [WhitespaceFilter]
        public ActionResult ContactUs()
        {
            return View();
        }
        [WhitespaceFilter]
        public ActionResult RoomeDetails()
        {
            return View();
        }
        [WhitespaceFilter]
        public ActionResult Gallery()
        {
            return View();
        }
    }
}