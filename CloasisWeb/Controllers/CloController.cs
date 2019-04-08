using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloasisWeb.Controllers
{
    public class CloController : Controller
    {
        // GET: Clo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DepartmentClos()
        {
            return View();
        }
        public ActionResult ProgramClos()
        {
            return View();
        }
        public ActionResult FacultyClos()
        {
            return View();
        }
    }
}