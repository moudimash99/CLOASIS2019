using ApiHelper.Client;
using CloasisWeb.ApiInfrastructure;
using CloasisWeb.ApiInfrastructure.Client;
using CloasisWeb.ApiInfrastructure.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CloasisWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    { 

        private readonly ICourseClient client;
        private readonly ICurrentSemesterClient cclient;
        public HomeController(ICourseClient client, ICurrentSemesterClient cclient)
        {
            this.client = client;
            this.cclient = cclient;
        }
        public HomeController()
        {
            var contextWrapper = new TokenContainer();
            var httpclient = HttpClientInstance.Instance; 
            httpclient = GlobalURL.AddHeader(httpclient);  
            var apiClient = new ApiClient(httpclient, contextWrapper);
            client = new CourseClient(apiClient);
            cclient = new CurrentSemesterClient(apiClient);
        }


        public async Task<ActionResult> Index()
        { 

            var courses = await client.GetAll();
            //var current = await cclient.GetAll();
            ViewBag.courses = courses;
          //  ViewBag.current = current.FirstOrDefault().SemesterTitle + " " + current.FirstOrDefault().YearTitle;
            ViewBag.current = "";
            return View(); 
        } 
     
    }
}