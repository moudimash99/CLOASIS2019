using CloasisWeb.ApiInfrastructure.ApiModels;
using CloasisWeb.ApiInfrastructure.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface ICLOClient
    {

        // A AP C CO COU D P 
        Task<List<ACloApiModel>> GetAllA(int d);
        Task<ACloApiModel> GetA(long id);
        Task<CLOResponse.AddACloResponse> AddNewA(ACloApiModel model);
        Task<CLOResponse.UpdateACloResponse> UpdateA(ACloApiModel model);
        Task<bool> DeleteA(long id);

        //AP
        Task<List<APCloApiModel>> GetAllAP(int d);
        Task<APCloApiModel> GetAP(long id);
        Task<CLOResponse.AddAPCloResponse> AddNewAP(APCloApiModel model);
        Task<CLOResponse.UpdateAPCloResponse> UpdateAP(APCloApiModel model);
        Task<bool> DeleteAP(long id);
        //C
        Task<List<CCloApiModel>> GetAllC(int d);
        Task<CCloApiModel> GetC(long id);
        Task<CLOResponse.AddCCloResponse> AddNewC(CCloApiModel model);
        Task<CLOResponse.UpdateCCloResponse> UpdateC(CCloApiModel model);
        Task<bool> DeleteC(long id);

        //CO
        Task<List<COCloApiModel>> GetAllCO(int d);
        Task<COCloApiModel> GetCO(long id);
        Task<CLOResponse.AddCOCloResponse> AddNewCO(COCloApiModel model);
        Task<CLOResponse.UpdateCOCloResponse> UpdateCO(COCloApiModel model);
        Task<bool> DeleteCO(long id);

        //COU
        Task<List<COUCloApiModel>> GetAllCOU(int d);
        Task<COUCloApiModel> GetCOU(long id);
        Task<CLOResponse.AddCOUCloResponse> AddNewCOU(COUCloApiModel model);
        Task<CLOResponse.UpdateCOUCloResponse> UpdateCOU(COUCloApiModel model);
        Task<bool> DeleteCOU(long id);

        //D
        Task<List<DCloApiModel>> GetAllD(int d);
        Task<DCloApiModel> GetD(long id);
        Task<CLOResponse.AddDCloResponse> AddNewD(DCloApiModel model);
        Task<CLOResponse.UpdateDCloResponse> UpdateD(DCloApiModel model);
        Task<bool> DeleteD(long id);

        //P
        Task<List<PCloApiModel>> GetAllP(int d);
        Task<PCloApiModel> GetP(long id);
        Task<CLOResponse.AddPCloResponse> AddNewP(PCloApiModel model);
        Task<CLOResponse.UpdatePCloResponse> UpdateP(PCloApiModel model);
        Task<bool> DeleteP(long id);


    }
}
