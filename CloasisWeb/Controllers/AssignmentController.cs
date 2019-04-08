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
    public class AssignmentController : Controller
    {
        private readonly IAssignmentClient client;
        private readonly IAssignmentTypeClient tclient;
        public AssignmentController(IAssignmentClient client, IAssignmentTypeClient tclient)
        {
            this.client = client;
            this.tclient = tclient;
        }

        public AssignmentController()
        {
            var contextWrapper = new TokenContainer();
            var httpclient = HttpClientInstance.Instance; 
            var apiClient = new ApiClient(httpclient, contextWrapper);
            client = new AssignmentsClient(apiClient);
            tclient = new AssignmentTypeClient(apiClient);
        }
        public async Task<ActionResult> Assignments(int courseOfferingId)
        {
            ViewBag.CourseId = courseOfferingId;
            ViewBag.assignmets = await client.GetAll(courseOfferingId);
            ViewBag.assignmettypes = await tclient.GetAll();
            return View();
        }

        public async Task<ActionResult> AddAssignment()
        {
            AssignmentsApiAddModel model = new AssignmentsApiAddModel();
            model.AssignmentDate = DateTime.Now;
            model.AssignmentType = "Homework";
            model.AssignmentTypeId = 1;
            model.CourseOfferingId = 1;
            model.Title = "Added from Cloasis App";
            model.MaxPoints = 100;
            model.Weight = (0.142857f);
            model.isGraded = true;
            model.DisplayOrder = 200;
            model.isGroupAssignment = false;
            model.ShortTitle = "HW1-1234";
            model.ParentAssignmentId = 0;
            model.GradeFormula = null; 
            var result = await client.AddNew(model);

            return View();
        }
        public async Task<ActionResult> EditAssignment()
        {
            AssignmentsApiUpdateModel model = new AssignmentsApiUpdateModel();
            model.AssignmentId = 4;
            model.AssignmentDate = DateTime.Now;
            model.AssignmentType = "Homework";
            model.AssignmentTypeId = 1;
            model.CourseOfferingId = 1;
            model.Title = "Added from Cloasis App";
            model.MaxPoints = 100;
            model.Weight = (0.142857f);
            model.isGraded = true;
            model.DisplayOrder = 200;
            model.isGroupAssignment = false;
            model.ShortTitle = "HW1-1234";
            model.ParentAssignmentId = 0;
            model.GradeFormula = null;
            var result = await client.Update(model);

            return View();
        }

        public async Task<ActionResult> DeleteAssignment()
        { 
            var result = await client.Delete(396); 
            return View();
        }
        public ActionResult Questions()
        {
            return View();
        }
       
    }
}