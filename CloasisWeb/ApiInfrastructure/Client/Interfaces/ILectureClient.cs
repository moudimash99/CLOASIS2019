using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface ILectureClient
    {
        Task<List<LectureApiModel>> GetAll(int courseOfferingId);
        Task<LectureApiModel> Get(long id);
        Task<LectureResponse.AddResponse> AddNew(LectureApiModel model);
        Task<LectureResponse.UpdateResponse> Update(LectureApiModel model);
        Task<string> Delete(long id);
    }
}
