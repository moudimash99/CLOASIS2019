using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class GradeResponse
    {
        public class AllResponse : ApiResponse<List<GradeApiModel>>
        {
        }
        public class GetResponse : ApiResponse<GradeApiModel>
        {
        }
        public class UpdateResponse : ApiResponse<int>
        {
        }
        public class DeleteResponse : ApiResponse<bool>
        {
        }
        public class AddResponse : ApiResponse<int>
        {
        }
    }
}