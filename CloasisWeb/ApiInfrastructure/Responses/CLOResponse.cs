using ApiHelper.Response;
using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.Responses
{
    public class CLOResponse
    {
        public class AllACloResponse : ApiResponse<List<ACloApiModel>>
        {
        }
        public class GetACloResponse : ApiResponse<ACloApiModel>
        {
        }
        public class UpdateACloResponse : ApiResponse<int>
        {
        }
        public class DeleteACloResponse : ApiResponse<bool>
        {
        }
        public class AddACloResponse : ApiResponse<int>
        {
        }
       
        //AP
        public class AllAPCloResponse : ApiResponse<List<APCloApiModel>>
        {
        }
        public class GetAPCloResponse : ApiResponse<APCloApiModel>
        {
        }
        public class UpdateAPCloResponse : ApiResponse<int>
        {
        }
        public class DeleteAPCloResponse : ApiResponse<bool>
        {
        }
        public class AddAPCloResponse : ApiResponse<int>
        {
        }

        //C
        public class AllCCloResponse : ApiResponse<List<CCloApiModel>>
        {
        }
        public class GetCCloResponse : ApiResponse<CCloApiModel>
        {
        }
        public class UpdateCCloResponse : ApiResponse<int>
        {
        }
        public class DeleteCCloResponse : ApiResponse<bool>
        {
        }
        public class AddCCloResponse : ApiResponse<int>
        {
        }

        //CO
        public class AllCOCloResponse : ApiResponse<List<COCloApiModel>>
        {
        }
        public class GetCOCloResponse : ApiResponse<COCloApiModel>
        {
        }
        public class UpdateCOCloResponse : ApiResponse<int>
        {
        }
        public class DeleteCOCloResponse : ApiResponse<bool>
        {
        }
        public class AddCOCloResponse : ApiResponse<int>
        {
        }

        //COU
        public class AllCOUCloResponse : ApiResponse<List<COUCloApiModel>>
        {
        }
        public class GetCOUCloResponse : ApiResponse<COUCloApiModel>
        {
        }
        public class UpdateCOUCloResponse : ApiResponse<int>
        {
        }
        public class DeleteCOUCloResponse : ApiResponse<bool>
        {
        }
        public class AddCOUCloResponse : ApiResponse<int>
        {
        }

        //D
        public class AllDCloResponse : ApiResponse<List<DCloApiModel>>
        {
        }
        public class GetDCloResponse : ApiResponse<DCloApiModel>
        {
        }
        public class UpdateDCloResponse : ApiResponse<int>
        {
        }
        public class DeleteDCloResponse : ApiResponse<bool>
        {
        }
        public class AddDCloResponse : ApiResponse<int>
        {
        }

        //P
        public class AllPCloResponse : ApiResponse<List<PCloApiModel>>
        {
        }
        public class GetPCloResponse : ApiResponse<PCloApiModel>
        {
        }
        public class UpdatePCloResponse : ApiResponse<int>
        {
        }
        public class DeletePCloResponse : ApiResponse<bool>
        {
        }
        public class AddPCloResponse : ApiResponse<int>
        {
        }

    }
}