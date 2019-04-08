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
    //[Authorize]
    public class CourseController : Controller
    {
        private readonly IStudentCourseClient sclient;
        private readonly IAttendanceClient aclient;
        private readonly INoteClient nclient;
        private readonly IGradeClient gclient;
        private readonly ICLOClient cclient;
        private readonly IStatisticsClient statclient;
        public CourseController(IStudentCourseClient sclient, IAttendanceClient aclient, INoteClient nclient, IGradeClient gclient, ICLOClient cclient)
        {
            this.sclient = sclient;
            this.aclient = aclient;
            this.nclient = nclient;
            this.gclient = gclient;
            this.cclient = cclient;
        }
        public CourseController()
        {
            var contextWrapper = new TokenContainer();
            var httpclient = HttpClientInstance.Instance;
            httpclient = GlobalURL.AddHeader(httpclient);
            var apiClient = new ApiClient(httpclient, contextWrapper); 
            sclient = new StudentCourseClient(apiClient);
            aclient = new AttendanceClient(apiClient);
            nclient = new NoteClient(apiClient);
            gclient = new GradeClient(apiClient);
            cclient = new CLOClient(apiClient);
            statclient = new StatisticsClient(apiClient);
        }

        public ActionResult Browse()
        { 
            return View();
        }

        public async Task<ActionResult> Index(int courseId)
        {
            ViewBag.stats = await statclient.GetAllStatisticsByAssignment(courseId);
            ViewBag.stats2 = await statclient.GetAllStatisticsByQuestion(courseId);
            var students = await sclient.GetAll(courseId);
            //var AllTemp = new List<StudentApiModel>();

            //var st1 = new StudentApiModel();
            //st1.AUBID = 201804703;
            //st1.email = "aaa00@mail.aub.edu";
            //st1.FirstName = "Ahmad";
            //st1.LastName = "Ali";
            //st1.CourseTitle = "CMPS 253";
            //st1.CourseOfferingID = courseId;
            //st1.Picture = "https://d3gyiijzpk1c44.cloudfront.net/upload/product_photos/base/0/44/127/original1.2916102.1.jpg";


            //var st2 = new StudentApiModel();
            //st2.AUBID = 201804704;
            //st2.email = "aaa01@mail.aub.edu";
            //st2.FirstName = "Ali";
            //st2.LastName = "Ahmad";
            //st2.CourseTitle = "CMPS 253";
            //st2.CourseOfferingID = courseId;
            //st2.Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAWwHitpUedO7G_p51pYMJG0ozWS612COS-m-E6-ETExnE9EV19Q";

            //AllTemp.Add(st1);
            //AllTemp.Add(st2);

            //var students = AllTemp;
            ViewBag.students = students;
            var randstudent = students.FirstOrDefault();
            ViewBag.CourseTitle = randstudent.CourseTitle;
            ViewBag.CourseId = randstudent.CourseOfferingID;
            ViewBag.SemesterTitle = randstudent.SemesterTitle;

            ViewBag.att = await aclient.GetAll(randstudent.CourseOfferingID);
            //   ViewBag.grades = await gclient.GetAll(randstudent.CourseOfferingID); ;
            var CourseClo = await cclient.GetAllCOU(randstudent.CourseOfferingID);
            ViewBag.Clos = CourseClo;
            ViewBag.Notes = await nclient.GetAll(); ; 
            return View();
        }
        public async Task<ActionResult> Students(int courseId)
        {
            var students = await sclient.GetAll(courseId);
            ViewBag.students = students;
            var randstudent = students.FirstOrDefault();
            ViewBag.CourseTitle= randstudent.CourseTitle;
            ViewBag.SemesterTitle = randstudent.SemesterTitle;
            return View();
        }

        public JsonResult GetStudent(int studentId)
        {
            return null;
        }

        public ActionResult CourseMaker()
        {
            return View();
        }

        public ActionResult NewCourseOffering()
        {
            return View();
        }

        public ActionResult CourseGradeDistribution()
        {
            return View();
        }
        public ActionResult MyCourses()
        {
            return View();
        }
    }
}