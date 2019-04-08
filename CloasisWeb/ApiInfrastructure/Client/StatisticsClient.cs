using ApiHelper.Client;
using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Client.Interfaces;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Client
{
    public class StatisticsClient : ClientBase, IStatisticsClient
    {
        private const string generalUri = "Stats";
        private const string getAllCourseAssignments= generalUri + "/CourseAssginments?courseOfferingId=";
        private const string getAllAssignmentQuestions = generalUri + "/AssignmentQuestions?assignmentId=";

        public StatisticsClient(IApiClient apiClient) : base(apiClient)
        {
        } 

        public async Task<List<StatisticsByAssignmentApiModel>> GetAllStatisticsByAssignment(int courseOfferingId)
        {
            var response = await GetJsonDecodedContent<StatisticsResponse.StatisticsByAssignmentResponse, List<StatisticsByAssignmentApiModel>>(getAllCourseAssignments + courseOfferingId);
            return response.Data;
        }

        public async Task<List<StatisticsByQuestionApiModel>> GetAllStatisticsByQuestion(int assignmentId)
        {
            var response = await GetJsonDecodedContent<StatisticsResponse.StatisticsByQuestionResponse, List<StatisticsByQuestionApiModel>>(getAllAssignmentQuestions + assignmentId);
            return response.Data;
        }
    }
}
