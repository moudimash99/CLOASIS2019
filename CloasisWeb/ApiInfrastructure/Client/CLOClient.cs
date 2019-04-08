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
    public class CLOClient : ClientBase, ICLOClient
    {

        // A AP C CO COU D P 

        private const string generalUri = "CLOs/";
        private const string getAllA = generalUri + "Assignment/";
        private const string getAllAP = generalUri + "AssignmentPart/";
        private const string getAllC = generalUri + "Course/";
        private const string getAllCO = generalUri + "CourseOffering/";
        private const string getAllCOU = generalUri + "CourseOfferingCLOUnits/";
        private const string getAllD = generalUri + "Department/";
        private const string getAllP = generalUri + "Program/";

        public CLOClient(IApiClient apiClient) : base(apiClient)
        {
        }

        public Task<CLOResponse.AddACloResponse> AddNewA(ACloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.AddAPCloResponse> AddNewAP(APCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.AddCCloResponse> AddNewC(CCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.AddCOCloResponse> AddNewCO(COCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.AddCOUCloResponse> AddNewCOU(COUCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.AddDCloResponse> AddNewD(DCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.AddPCloResponse> AddNewP(PCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteA(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAP(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteC(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCO(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCOU(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteD(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteP(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ACloApiModel> GetA(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ACloApiModel>> GetAllA(int d)
        {
            var response = await GetJsonDecodedContent<CLOResponse.AllACloResponse, List<ACloApiModel>>(getAllA + d);
            return response.Data;
        }

        public async Task<List<APCloApiModel>> GetAllAP(int d)
        {
            var response = await GetJsonDecodedContent<CLOResponse.AllAPCloResponse, List<APCloApiModel>>(getAllAP + d);
            return response.Data;
        }

        public async Task<List<CCloApiModel>> GetAllC(int d)
        {
            var response = await GetJsonDecodedContent<CLOResponse.AllCCloResponse, List<CCloApiModel>>(getAllC + d);
            return response.Data;
        }

        public async Task<List<COCloApiModel>> GetAllCO(int d)
        {
            var response = await GetJsonDecodedContent<CLOResponse.AllCOCloResponse, List<COCloApiModel>>(getAllCO + d);
            return response.Data;
        }

        public async Task<List<COUCloApiModel>> GetAllCOU(int d)
        {
            var response = await GetJsonDecodedContent<CLOResponse.AllCOUCloResponse, List<COUCloApiModel>>(getAllCOU + d);
            return response.Data;
        }

        public async Task<List<DCloApiModel>> GetAllD(int d)
        {
            var response = await GetJsonDecodedContent<CLOResponse.AllDCloResponse, List<DCloApiModel>>(getAllD + d);
            return response.Data;
        }

        public async Task<List<PCloApiModel>> GetAllP(int d)
        {
            var response = await GetJsonDecodedContent<CLOResponse.AllPCloResponse, List<PCloApiModel>>(getAllP + d);
            return response.Data;
        }

        public Task<APCloApiModel> GetAP(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CCloApiModel> GetC(long id)
        {
            throw new NotImplementedException();
        }

        public Task<COCloApiModel> GetCO(long id)
        {
            throw new NotImplementedException();
        }

        public Task<COUCloApiModel> GetCOU(long id)
        {
            throw new NotImplementedException();
        }

        public Task<DCloApiModel> GetD(long id)
        {
            throw new NotImplementedException();
        }

        public Task<PCloApiModel> GetP(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.UpdateACloResponse> UpdateA(ACloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.UpdateAPCloResponse> UpdateAP(APCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.UpdateCCloResponse> UpdateC(CCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.UpdateCOCloResponse> UpdateCO(COCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.UpdateCOUCloResponse> UpdateCOU(COUCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.UpdateDCloResponse> UpdateD(DCloApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CLOResponse.UpdatePCloResponse> UpdateP(PCloApiModel model)
        {
            throw new NotImplementedException();
        }
    }
}