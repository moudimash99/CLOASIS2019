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
    public class LectureClient : ClientBase, ILectureClient
    {
        private const string generalUri = "Lectures"; 

        public LectureClient(IApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<LectureResponse.AddResponse> AddNew(LectureApiModel model)
        {
            var response = await PostEncodedContent<LectureResponse.AddResponse, DefaultResponseApiModel, LectureApiModel>(generalUri, model);
            return response;
        }

        public async Task<string> Delete(long id)
        {
            var response = await DeleteDecodedContent<LectureResponse.DeleteResponse, string>(generalUri + "/" + id);
            return response.Data;
        }

        public Task<LectureApiModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<LectureApiModel>> GetAll(int courseOfferingId)
        {
            var response = await GetJsonDecodedContent<LectureResponse.AllResponse, List<LectureApiModel>>(generalUri + "?courseOfferingId=" + courseOfferingId);
            return response.Data;
        }

        public async Task<LectureResponse.UpdateResponse> Update(LectureApiModel model)
        {
            var response = await PutEncodedContentWithSimpleResponse<LectureResponse.UpdateResponse, DefaultResponseApiModel, LectureApiModel>(generalUri, model);
            return response;
        }
    }
}