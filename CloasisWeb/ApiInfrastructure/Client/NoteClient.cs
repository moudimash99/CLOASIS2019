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
    public class NoteClient : ClientBase, INoteClient
    {
        private const string generalUri = "Students/Notes/";
        private const string getAllUri = generalUri ;
        private const string getUri = generalUri + "get/";
        private const string updateUri = generalUri + "update";
        private const string deleteUri = generalUri + "del/";
        private const string createUri = generalUri + "add/";

        public NoteClient(IApiClient apiClient) : base(apiClient)
        {
        }
        public async Task<List<NoteApiModel>> GetAll()
        {
            var response = await GetJsonDecodedContent<NoteResponse.AllResponse, List<NoteApiModel>>(getAllUri);
            return response.Data;

        }

        public async Task<bool> Delete(long id)
        {
            var response = await GetJsonDecodedContent<NoteResponse.DeleteResponse, bool>(deleteUri + id);
            return response.Data;
        }

        public async Task<NoteApiModel> Get(long id)
        {
            var response = await GetJsonDecodedContent<NoteResponse.GetResponse, NoteApiModel>(getUri + id);
            return response.Data;
        }

        public async Task<NoteResponse.AddResponse> AddNew(NoteApiModel model)
        {
            var response = await PostEncodedContentWithSimpleResponse<NoteResponse.AddResponse, NoteApiModel>(createUri, model);
            return response;

        }

        public async Task<NoteResponse.UpdateResponse> Update(NoteApiModel model)
        {
            var response = await PostEncodedContentWithSimpleResponse<NoteResponse.UpdateResponse, NoteApiModel>(updateUri, model);
            return response;
        }
    }
}