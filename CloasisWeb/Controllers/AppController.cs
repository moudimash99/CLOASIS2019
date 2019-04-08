using CloasisWeb.ApiInfrastructure.Client.Interfaces;
using CloasisWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloasisWeb.Controllers
{
    public class AppController : Controller
    {
        public AppController()
        {
            email = new CloasisWeb.ApiInfrastructure.Client.Interfaces.EmailService();
        }
        private IEmailService email;
       

        public ActionResult Email(int id1, int id2)
        {

            EmailViewModel e = new EmailViewModel();
            e.id1 = id1;
            e.id2 = id2;
            return View(e);
        }

        [HttpPost]
        public ActionResult Email(EmailViewModel emailViewModel, int id1, int id2)
        {
            email.SendEmailAsync("moudimash99@gmail.com", emailViewModel.Subject, emailViewModel.Message);

            return Email(emailViewModel.id1, emailViewModel.id2);
        }
    }
}