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

    public class StudentCourseClient : ClientBase, IStudentCourseClient
    {
        private const string generalUri = "Students/";
        private const string getAllUri = generalUri + "?courseOfferingId=";
        //private const string getUri = generalUri + "get/";
        //private const string updateUri = generalUri + "update";
        //private const string deleteUri = generalUri + "del/";
        //private const string createUri = generalUri + "add/";

        public StudentCourseClient(IApiClient apiClient)
            : base(apiClient)
        {
        }

        public async Task<List<StudentApiModel>> GetAll(int courseOfferingId)
        {
            var response = await GetJsonDecodedContent<AllStudentCourseResponse, List<StudentApiModel>>(getAllUri + courseOfferingId );
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