using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class StatisticsResponse
    {
        public class StatisticsByAssignmentResponse : ApiResponse<List<StatisticsByAssignmentApiModel>>
        {
        }
        public class StatisticsByQuestionResponse : ApiResponse<List<StatisticsByQuestionApiModel>>
        {
        } 
    }
}