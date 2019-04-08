using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloasisWeb.Controllers
{
    [Authorize]
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult ImportStudent()
        {
            return View();
        }
        public ActionResult RegisterStudent()
        {
            return View();
        }

    }
}