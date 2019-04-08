using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface IAssignmentClient
    {
        Task<List<AssignmentsApiModel>> GetAll(int courseOfferingId);
        Task<AssignmentsApiModel> Get(long id);
        Task<AssignmentsResponse.AddResponse> AddNew(AssignmentsApiAddModel model);
        Task<AssignmentsResponse.UpdateResponse> Update(AssignmentsApiUpdateModel model);
        Task<String> Delete(long id);
    }
}
