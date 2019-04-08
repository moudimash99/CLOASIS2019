using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface IQuestionClient
    {
        Task<List<QuestionApiModel>> GetAll(int assignmentId);
        Task<QuestionApiModel> Get(long id);
        Task<QuestionResponse.AddResponse> AddNew(QuestionApiAddModel model);
        Task<QuestionResponse.UpdateResponse> Update(QuestionApiUpdateModel model);
        Task<string> Delete(long id);
    }
}
