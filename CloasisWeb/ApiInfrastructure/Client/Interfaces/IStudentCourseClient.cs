using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{ 

    public interface IStudentCourseClient
    {
        Task<List<StudentApiModel>> GetAll(int courseOfferingId);
        //Task<CourseApiModel> Get(long id);
        //Task<AddStudentCourseResponse> AddNew(StudentCourseApiModel model);
        //Task<UpdateStudentCourseResponse> Update(StudentCourseApiModel model);
        //Task<bool> Delete(long id);
    }
}
