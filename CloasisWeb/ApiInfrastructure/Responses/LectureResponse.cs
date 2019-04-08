using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class LectureResponse
    {
        public class AllResponse : ApiResponse<List<LectureApiModel>>
        {
        }
        public class GetResponse : ApiResponse<LectureApiModel>
        {
        }
        public class UpdateResponse : ApiResponse<DefaultResponseApiModel>
        {
        }
        public class DeleteResponse : ApiResponse<string>
        {
        }
        public class AddResponse : ApiResponse<DefaultResponseApiModel>
        {
        }
    }
}