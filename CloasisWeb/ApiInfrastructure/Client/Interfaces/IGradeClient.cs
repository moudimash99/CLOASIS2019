using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface IGradeClient
    {
        Task<List<GradeApiModel>> GetAll(int courseOfferingId);
        Task<GradeApiModel> Get(long id);
        Task<GradeResponse.AddResponse> AddNew(GradeApiModel model);
        Task<GradeResponse.UpdateResponse> Update(GradeApiModel model);
        Task<bool> Delete(long id);
    }
}
