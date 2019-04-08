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
 
    public class TeamController : Controller
    {
        private readonly ITeamClient client;
        public TeamController(ITeamClient client)
        {
            this.client = client;
        }
        public TeamController()
        {
            var contextWrapper = new TokenContainer();
            var httpclient = HttpClientInstance.Instance;
            var apiClient = new ApiClient(httpclient, contextWrapper);
            client = new TeamClient(apiClient);
        }
        public async Task<ActionResult> Index()
        {
            var allteam = await client.GetAll(1);
            return View();
        }
        public async Task<ActionResult> AddTeam()
        {
            TeamApiAddModel model = new TeamApiAddModel();
            model.Title = "Team 100";
            model.CourseOfferingId = 4;
            model.DisplayOrder = 10;
            var allteam = await client.AddNew(model);
            return View();
        }
        public async Task<ActionResult> UpdateTeam()
        {
            TeamApiModel model = new TeamApiModel();
            model.Title = "Team 100";
            model.TeamID= 1; 
            var allteam = await client.Update(model);
            return View();
        }
        public async Task<ActionResult> DeleteTeam()
        { 
            var allteam = await client.Delete(62);
            return View();
        }
        public ActionResult TeamMaker()
        {
            return View();
        }
    }
}