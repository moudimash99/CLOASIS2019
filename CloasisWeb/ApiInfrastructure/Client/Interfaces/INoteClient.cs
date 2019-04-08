using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface INoteClient
    {
        Task<List<NoteApiModel>> GetAll();
        Task<NoteApiModel> Get(long id);
        Task<NoteResponse.AddResponse> AddNew(NoteApiModel model);
        Task<NoteResponse.UpdateResponse> Update(NoteApiModel model);
        Task<bool> Delete(long id);
    }
}
