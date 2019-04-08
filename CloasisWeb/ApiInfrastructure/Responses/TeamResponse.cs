using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class TeamResponse
    {
        public class AllResponse : ApiResponse<List<TeamApiModel>>
        {
        }
        public class AllMembersResponse : ApiResponse<List<TeamApiMembersModel>>
        {
        }
        public class GetResponse : ApiResponse<TeamApiModel>
        {
        }
        public class UpdateResponse : ApiResponse<DefaultResponseApiModel>
        {
        }
        public class DeleteResponse : ApiResponse<string>
        {
        }
        public class AddMemberToTeamResponse : ApiResponse<string>
        {
        }
        public class DeleteMemberFromTeamResponse : ApiResponse<string>
        {
        }
        public class AddResponse : ApiResponse<DefaultResponseApiModel>
        {
        }
    }
}