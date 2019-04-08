using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class AllCourseResponse : ApiResponse<List<CourseApiModel>>
    {
    }
    public class GetCourseResponse : ApiResponse<CourseApiModel>
    {
    }
    public class UpdateCourseResponse : ApiResponse<int>
    {
    }
    public class DeleteCourseResponse : ApiResponse<bool>
    {
    }
    public class AddCourseResponse : ApiResponse<int>
    {
    }
}