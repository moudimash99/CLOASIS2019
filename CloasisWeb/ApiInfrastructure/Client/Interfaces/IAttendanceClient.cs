using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface IAttendanceClient
    {
        Task<List<AttendanceApiModel>> GetAll(int CourseOfferingId);
        Task<AttendanceApiModel> Get(long id);
        Task<AttendanceResponse.AddResponse> AddNew(AttendanceApiModel model);
        Task<AttendanceResponse.UpdateResponse> Update(AttendanceApiModel model);
        Task<bool> Delete(long id);
    }
}
