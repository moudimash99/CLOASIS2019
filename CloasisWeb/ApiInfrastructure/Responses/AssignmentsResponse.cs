using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class AssignmentsResponse
    {
        public class AllResponse : ApiResponse<List<AssignmentsApiModel>>
        {
        }
        public class GetResponse : ApiResponse<AssignmentsApiModel>
        {
        }
        public class UpdateResponse : ApiResponse<DefaultResponseApiModel>
        {
        }
        public class DeleteResponse : ApiResponse<String>
        {
        }
        public class AddResponse : ApiResponse<DefaultResponseApiModel>
        {
        }
    }
}