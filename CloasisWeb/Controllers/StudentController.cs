using ApiHelper.Client;
using CloasisWeb.ApiInfrastructure;
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
    [Authorize]
    public class StudentController : Controller
    {
        private readonly IStudentCourseClient client;
        public StudentController(IStudentCourseClient client)
        {
            this.client = client;
        }
        public StudentController()
        {
            var contextWrapper = new TokenContainer();
            var apiClient = new ApiClient(HttpClientInstance.Instance, contextWrapper);
            client = new StudentCourseClient(apiClient);
        }
        public async Task<ActionResult> Index(int Id)
        {
            var students = await client.GetAll(Id);
            ViewBag.students = students;
            return View();
        }
      
    }
}