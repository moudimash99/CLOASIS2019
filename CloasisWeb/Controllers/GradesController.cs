﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloasisWeb.Controllers
{
    [Authorize]
    public class GradesController : Controller
    {
        // GET: Grades
        public ActionResult Index()
        {
            return View();
        }
         
    }
}