using Studio27SalonOfBeauty.Models.BindingModels;
using System.Net.Mail;
using System.Web.Mvc;


namespace Studio27SalonOfBeauty.Controllers
{
    [RoutePrefix("Contact")]
    public class ContactController : Controller
    {
        //private EmailService service;


        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendMail(SendMailBinding model)
        {
            var gmailSmtp = "smtp.gmail.com";
            var smtpPort = 587;

            var gmailMail = "gabriela.banova0204@gmail.com";
            var gmailPassword = "pass";

            var emailRecepient = "gabriela_banova@abv.bg";


            SmtpClient smtpClient = new SmtpClient(gmailSmtp, smtpPort);

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential(gmailMail, gmailPassword);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction("InvalidSendMailModel","Error");
            }
            System.Net.Mail.MailMessage theMessage = new System.Net.Mail.MailMessage();
            theMessage.From = new MailAddress(model.Email);
            theMessage.To.Add(emailRecepient);
            theMessage.Body = model.Message;
            smtpClient.Send(theMessage);

            return RedirectToAction("SuccessfullySendMail");
        }

        public ActionResult SuccessfullySendMail()
        {
            return View();
        }

    }
}