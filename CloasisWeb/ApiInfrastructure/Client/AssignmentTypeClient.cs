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
    public class AssignmentTypeClient : ClientBase, IAssignmentTypeClient
    {
        private const string generalUri = "AssignmentTypes";
        private const string getAllUri = generalUri;
        private const string getUri = generalUri + "get/";
        private const string updateUri = generalUri + "update";
        private const string deleteUri = generalUri + "del/";
        private const string createUri = generalUri + "add/";

        public AssignmentTypeClient(IApiClient apiClient) : base(apiClient)
        {
        }
        public async Task<List<AssignmentTypeApiModel>> GetAll()
        {
            var response = await GetJsonDecodedContent<AssignmentTypeResponse.AllResponse, List<AssignmentTypeApiModel>>(getAllUri);
            return response.Data;

        }

        public async Task<bool> Delete(long id)
        {
            var response = await GetJsonDecodedContent<AssignmentTypeResponse.DeleteResponse, bool>(deleteUri + id);
            return response.Data;
        }

        public async Task<AssignmentTypeApiModel> Get(long id)
        {
            var response = await GetJsonDecodedContent<AssignmentTypeResponse.GetResponse, AssignmentTypeApiModel>(getUri + id);
            return response.Data;
        }

        public async Task<AssignmentTypeResponse.AddResponse> AddNew(AssignmentTypeApiModel model)
        {
            var response = await PostEncodedContentWithSimpleResponse<AssignmentTypeResponse.AddResponse, AssignmentTypeApiModel>(createUri, model);
            return response;

        }

        public async Task<AssignmentTypeResponse.UpdateResponse> Update(AssignmentTypeApiModel model)
        {
            var response = await PostEncodedContentWithSimpleResponse<AssignmentTypeResponse.UpdateResponse, AssignmentTypeApiModel>(updateUri, model);
            return response;
        }
    }
}