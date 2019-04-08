using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class AssignmentTypeResponse
    {
        public class AllResponse : ApiResponse<List<AssignmentTypeApiModel>>
        {
        }
        public class GetResponse : ApiResponse<AssignmentTypeApiModel>
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