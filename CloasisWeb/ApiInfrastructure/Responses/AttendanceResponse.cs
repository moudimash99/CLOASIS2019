using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class AttendanceResponse
    {
        public class AllResponse : ApiResponse<List<AttendanceApiModel>>
        {
        }
        public class GetResponse : ApiResponse<AttendanceApiModel>
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