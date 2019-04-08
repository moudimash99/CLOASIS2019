using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class AllStudentCourseResponse : ApiResponse<List<StudentApiModel>>
    {
    }
    public class GetStudentCourseResponse : ApiResponse<StudentApiModel>
    {
    }
    public class UpdateStudentCourseResponse : ApiResponse<int>
    {
    }
    public class DeleteStudentCourseResponse : ApiResponse<bool>
    {
    }
    public class AddStudentCourseResponse : ApiResponse<int>
    {
    }
}