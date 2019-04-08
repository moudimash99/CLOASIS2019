using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface ITeamClient
    {
        Task<List<TeamApiModel>> GetAll(int courseOfferingId); 
        Task<TeamResponse.AddResponse> AddNew(TeamApiAddModel model);
        Task<TeamResponse.UpdateResponse> Update(TeamApiModel model);
        Task<string> Delete(long id);

        Task<List<TeamApiMembersModel>> GetAllTeamMembers(int TeamId);
        Task<List<TeamApiMembersModel>> GetAllTeamMembersByCourse(int courseOfferingId);

        Task<TeamResponse.AddMemberToTeamResponse> AddMemberToTeam(int teamId, int memberId);
        Task<TeamResponse.DeleteMemberFromTeamResponse> DeleteMemberToTeam(int teamId, int memberId);
    }
}
