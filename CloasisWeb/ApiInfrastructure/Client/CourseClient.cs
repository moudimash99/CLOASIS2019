using ApiHelper.Client;
using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Client.Interfaces;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Client
{ 

    public class CourseClient : ClientBase, ICourseClient
    {
        private const string generalUri = "Courses";
        private const string getAllUri = generalUri + "?instructorId=";
        //private const string getUri = generalUri + "get/";
        //private const string updateUri = generalUri + "update";
        //private const string deleteUri = generalUri + "del/";
        //private const string createUri = generalUri + "add/";

        public CourseClient(IApiClient apiClient)
            : base(apiClient)
        {
        }
        public async Task<List<CourseApiModel>> GetAll()
        {
            var instructorId = 1; //later, here we can get instructorId from the instant user
         //   var TokenCode = "JdMWAwoR0QswHQPoPC9pCoEXsit5a6U6QwkaeqHOGRC/JDJatORjow==";
            var response = await GetJsonDecodedContent<AllCourseResponse, List<CourseApiModel>>(getAllUri + instructorId + "&allCourses=true");
            return response.Data;
        }

        //public async Task<bool> Delete(long id)
        //{
        //    var response = await GetJsonDecodedContent<DeleteAnnResponse, bool>(deleteUri + id);
        //    return response.Data;
        //}

        //public async Task<AnnApiModel> Get(long id)
        //{
        //    var response = await GetJsonDecodedContent<GetAnnResponse, AnnApiModel>(getUri + id);
        //    return response.Data;
        //}

        //public async Task<AddAnnResponse> AddNew(AnnApiModel model)
        //{
        //    var response = await PostEncodedContentWithSimpleResponse<AddAnnResponse, AnnApiModel>(createUri, model);
        //    return response;

        //}

        //public async Task<UpdateAnnResponse> Update(AnnApiModel model)
        //{
        //    var response = await PostEncodedContentWithSimpleResponse<UpdateAnnResponse, AnnApiModel>(updateUri, model);
        //    return response;
        //}


    }
}