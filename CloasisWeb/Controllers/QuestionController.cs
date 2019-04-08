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
    public class QuestionController : Controller
    {
        private readonly IQuestionClient client; 
        public QuestionController(IQuestionClient client)
        {
            this.client = client; 
        }
        public QuestionController()
        {
            var contextWrapper = new TokenContainer();
            var httpclient = HttpClientInstance.Instance;
            var apiClient = new ApiClient(httpclient, contextWrapper);
            client = new QuestionClient(apiClient); 
        }
        public async Task<ActionResult> Index()
        {
            var questions = await client.GetAll(392);
            return View();
        }
        public async Task<ActionResult> AddQuestion()
        {
            QuestionApiAddModel model = new QuestionApiAddModel();
            model.AssignmentID = 392;
            model.Title = "Question 112";
            model.QuestionNumber = 1;
            model.MaxPoints = 6;
            model.AssignmentDate = DateTime.Now;
            model.Weight = 1;
            model.isGraded = false;
            model.QuestionPaperNumber = "1";


            var questions = await client.AddNew(model);
            return View();
        }
        public async Task<ActionResult> UpdateQuestion()
        {
            QuestionApiUpdateModel model = new QuestionApiUpdateModel();  
            model.AssignmentPartId = 291;
            model.AssignmentID = 392;
            model.Title = "Question 41";
            model.QuestionNumber = 1.0M;
            model.MaxPoints = 6.0M;
            model.AssignmentDate = DateTime.Now;
            model.Weight = 1.0M;
            model.isGraded = false;
            model.QuestionPaperNumber = "1";

            var questions = await client.Update(model);
            return View();
        }
        public async Task<ActionResult> DeleteQuestion()
        {
            var questions = await client.Delete(293);
            return View();
        }
    }
}