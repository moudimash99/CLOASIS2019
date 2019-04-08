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
    public class AttendanceClient : ClientBase, IAttendanceClient
    {
        private const string generalUri = "Attendance";
        private const string getAllUri = generalUri + "?courseOfferingId=";
        private const string getUri = generalUri + "get/";
        private const string updateUri = generalUri + "update";
        private const string deleteUri = generalUri + "del/";
        private const string createUri = generalUri + "add/";

        public AttendanceClient(IApiClient apiClient) : base(apiClient)
        {
        }
        public async Task<List<AttendanceApiModel>> GetAll(int CourseOfferingId)
        {
            var response = await GetJsonDecodedContent<AttendanceResponse.AllResponse, List<AttendanceApiModel>>(getAllUri + CourseOfferingId);
            return response.Data;

        }

        public async Task<bool> Delete(long id)
        {
            var response = await GetJsonDecodedContent<AttendanceResponse.DeleteResponse, bool>(deleteUri + id);
            return response.Data;
        }

        public async Task<AttendanceApiModel> Get(long id)
        {
            var response = await GetJsonDecodedContent<AttendanceResponse.GetResponse, AttendanceApiModel>(getUri + id);
            return response.Data;
        }

        public async Task<AttendanceResponse.AddResponse> AddNew(AttendanceApiModel model)
        {
            var response = await PostEncodedContentWithSimpleResponse<AttendanceResponse.AddResponse, AttendanceApiModel>(createUri, model);
            return response;

        }

        public async Task<AttendanceResponse.UpdateResponse> Update(AttendanceApiModel model)
        {
            var response = await PostEncodedContentWithSimpleResponse<AttendanceResponse.UpdateResponse, AttendanceApiModel>(updateUri, model);
            return response;
        }
    }
}