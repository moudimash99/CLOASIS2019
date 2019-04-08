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
    public class CurrentSemesterClient : ClientBase, ICurrentSemesterClient
    {
        private const string generalUri = "System/";
        private const string getAllUri = generalUri + "CurrentSemester"; 

        public CurrentSemesterClient(IApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<List<CurrentSemesterApiModel>> GetAll()
        { 
            var response = await GetJsonDecodedContent<CurrentSemesterResponse.GetResponse, List<CurrentSemesterApiModel>>(getAllUri);
            return response.Data;
        }

    }
}