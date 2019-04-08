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
    public class AssignmentsClient : ClientBase, IAssignmentClient
    {
        private const string generalUri = "Assignments";
        private const string getAllUri = generalUri + "?courseOfferingId=";
        private const string getUri = generalUri + "get/";
        private const string updateUri = generalUri + "";
        private const string deleteUri = generalUri + "/";
        private const string createUri = generalUri + "";

        public AssignmentsClient(IApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<List<AssignmentsApiModel>> GetAll(int courseOfferingId)
        {
            var response = await GetJsonDecodedContent<AssignmentsResponse.AllResponse, List<AssignmentsApiModel>>(getAllUri + courseOfferingId);
            return response.Data;

        }

        public async Task<String> Delete(long id)
        {
            var response = await DeleteDecodedContent<AssignmentsResponse.DeleteResponse, String>(generalUri + "/" + id);
            return response.Data;
        }

        public async Task<AssignmentsApiModel> Get(long id)
        {
            var response = await GetJsonDecodedContent<AssignmentsResponse.GetResponse, AssignmentsApiModel>(getUri + id);
            return response.Data;
        }

        public async Task<AssignmentsResponse.AddResponse> AddNew(AssignmentsApiAddModel model)
        {
            var response = await PostEncodedContent<AssignmentsResponse.AddResponse, DefaultResponseApiModel, AssignmentsApiAddModel>(createUri, model);
            return response;

        }

        public async Task<AssignmentsResponse.UpdateResponse> Update(AssignmentsApiUpdateModel model)
        {
            var response = await PutEncodedContentWithSimpleResponse<AssignmentsResponse.UpdateResponse, DefaultResponseApiModel, AssignmentsApiUpdateModel>(createUri, model);
            return response;
        }
    }
}