using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class CurrentSemesterResponse
    { 
        public class GetResponse : ApiResponse<List<CurrentSemesterApiModel>>
        {
        } 
    }
}