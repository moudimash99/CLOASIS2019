using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface IAssignmentTypeClient
    {
        Task<List<AssignmentTypeApiModel>> GetAll();
        Task<AssignmentTypeApiModel> Get(long id);
        Task<AssignmentTypeResponse.AddResponse> AddNew(AssignmentTypeApiModel model);
        Task<AssignmentTypeResponse.UpdateResponse> Update(AssignmentTypeApiModel model);
        Task<bool> Delete(long id);
    }
}
