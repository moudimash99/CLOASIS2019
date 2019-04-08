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
    public class GradeClient : ClientBase, IGradeClient
    {
        private const string generalUri = "Grades";
        private const string getAllUri = generalUri + "?courseOfferingId=";
        private const string getUri = generalUri + "get/";
        private const string updateUri = generalUri + "update";
        private const string deleteUri = generalUri + "del/";
        private const string createUri = generalUri + "add/";

        public GradeClient(IApiClient apiClient) : base(apiClient)
        {
        }
        public async Task<List<GradeApiModel>> GetAll(int courseOfferingId)
        {
            var response = await GetJsonDecodedContent<GradeResponse.AllResponse, List<GradeApiModel>>(getAllUri + courseOfferingId);
            return response.Data;

        }

        public async Task<bool> Delete(long id)
        {
            var response = await GetJsonDecodedContent<GradeResponse.DeleteResponse, bool>(deleteUri + id);
            return response.Data;
        }

        public async Task<GradeApiModel> Get(long id)
        {
            var response = await GetJsonDecodedContent<GradeResponse.GetResponse, GradeApiModel>(getUri + id);
            return response.Data;
        }

        public async Task<GradeResponse.AddResponse> AddNew(GradeApiModel model)
        {
            var response = await PostEncodedContentWithSimpleResponse<GradeResponse.AddResponse, GradeApiModel>(createUri, model);
            return response;

        }

        public async Task<GradeResponse.UpdateResponse> Update(GradeApiModel model)
        {
            var response = await PostEncodedContentWithSimpleResponse<GradeResponse.UpdateResponse, GradeApiModel>(updateUri, model);
            return response;
        }
    }
}


 