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
    public class TeamClient : ClientBase, ITeamClient
    {
        private const string generalUri = "Teams";

        public TeamClient(IApiClient apiClient) : base(apiClient)
        {
        }

        public Task<TeamResponse.AddMemberToTeamResponse> AddMemberToTeam(int teamId, int memberId)
        {
            throw new NotImplementedException();
        }

        public async Task<TeamResponse.AddResponse> AddNew(TeamApiAddModel model)
        {
            var response = await PostEncodedContent<TeamResponse.AddResponse, DefaultResponseApiModel, TeamApiAddModel>(generalUri, model);
            return response;
        }

        public async Task<string> Delete(long id)
        {
            var response = await DeleteDecodedContent<TeamResponse.DeleteResponse, string>(generalUri + "/" + id);
            return response.Data;
        }

        public Task<TeamResponse.DeleteMemberFromTeamResponse> DeleteMemberToTeam(int teamId, int memberId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TeamApiModel>> GetAll(int courseOfferingId)
        {
            var response = await GetJsonDecodedContent<TeamResponse.AllResponse, List<TeamApiModel>>(generalUri + "?courseOfferingId=" + courseOfferingId);
            return response.Data;
        }

        public Task<List<TeamApiMembersModel>> GetAllTeamMembers(int TeamId)
        {
            throw new NotImplementedException();
        }

        public Task<List<TeamApiMembersModel>> GetAllTeamMembersByCourse(int courseOfferingId)
        {
            throw new NotImplementedException();
        }

        public async Task<TeamResponse.UpdateResponse> Update(TeamApiModel model)
        {
            var response = await PutEncodedContentWithSimpleResponse<TeamResponse.UpdateResponse, DefaultResponseApiModel, TeamApiModel>(generalUri, model);
            return response;
        }
    }
}