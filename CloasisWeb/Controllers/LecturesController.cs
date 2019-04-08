using ApiHelper.Client;
using CloasisWeb.ApiInfrastructure;
using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Client;
using CloasisWeb.ApiInfrastructure.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CloasisWeb.Controllers
{
    
    public class LecturesController : Controller
    {
        private readonly ILectureClient client;
        public LecturesController(ILectureClient client)
        {
            this.client = client;
        }
        public LecturesController()
        {
            var contextWrapper = new TokenContainer();
            var httpclient = HttpClientInstance.Instance;
            var apiClient = new ApiClient(httpclient, contextWrapper);
            client = new LectureClient(apiClient);
        }
        public async Task<ActionResult> BrowseLectures()
        {
            ViewBag.lecs = await client.GetAll(1);
            return View();
        }
        public async Task<ActionResult> AddLecture(DateTime date)
        {
            var lec = new LectureApiModel();
            lec.CourseOfferingId = 3;
            lec.LectureDate = DateTime.Now;
            lec.LectureNumber = 555;
            var bl = await client.AddNew(lec);
            return  RedirectToAction("BrowseLectures");
        }
        public async Task<ActionResult> UpdateLectures()
        {
            var lec = new LectureApiModel();
            lec.LectureId = 1;
            lec.CourseOfferingId = 1;
            lec.LectureDate = DateTime.Now;
            lec.LectureNumber = 1234567;
            var bl = await client.Update(lec);
            return View();
        }
        public async Task<ActionResult> DeleteLectures()
        { 
            var bl = await client.Delete(1196);
            return View();
        }
        public ActionResult MakeLecture()
        {
            return View();
        }
    }
}