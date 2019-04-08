using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class DefaultResponseApiModel : ApiModel
    {
        public string Status { get; set; }
        public int Id { get; set; }
    
    }
}