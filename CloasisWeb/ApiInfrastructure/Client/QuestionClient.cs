using ApiHelper.Client;
using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Client.Interfaces;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic; 
using System.Threading.Tasks; 

namespace CloasisWeb.ApiInfrastructure.Client
{
    public class QuestionClient : ClientBase, IQuestionClient
    {
        private const string generalUri = "Questions"; 

        public QuestionClient(IApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<QuestionResponse.AddResponse> AddNew(QuestionApiAddModel model)
        {
            var response = await PostEncodedContent<QuestionResponse.AddResponse, DefaultResponseApiModel, QuestionApiAddModel>(generalUri, model);
            return response;
        }

        public async Task<string> Delete(long id)
        {
            var response = await DeleteDecodedContent<QuestionResponse.DeleteResponse, string>(generalUri + "/" + id);
            return response.Data;
        }

        public Task<QuestionApiModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<QuestionApiModel>> GetAll(int assignmentId)
        {
            var response = await GetJsonDecodedContent<QuestionResponse.AllResponse, List<QuestionApiModel>>(generalUri + "?assignmentId=" + assignmentId);
            return response.Data;
        }

        public async Task<QuestionResponse.UpdateResponse> Update(QuestionApiUpdateModel model)
        {
            var response = await PutEncodedContentWithSimpleResponse<QuestionResponse.UpdateResponse, DefaultResponseApiModel, QuestionApiUpdateModel>(generalUri + "?assignmentId=" + model.AssignmentID, model);
            return response;
        }
    }
}
