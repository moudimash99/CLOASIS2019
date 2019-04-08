using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{ 

    public class QuestionResponse
    {
        public class AllResponse : ApiResponse<List<QuestionApiModel>>
        {
        }
        public class GetResponse : ApiResponse<QuestionApiModel>
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
        public class Add2Response : ApiResponse<int>
        {
        }
    }
}