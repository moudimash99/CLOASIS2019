using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{ 
    public interface ICourseClient
    {
        Task<List<CourseApiModel>> GetAll();
        //Task<CourseApiModel> Get(long id);
        //Task<AddCourseResponse> AddNew(CourseApiModel model);
        //Task<UpdateCourseResponse> Update(CourseApiModel model);
        //Task<bool> Delete(long id);
    }
}
