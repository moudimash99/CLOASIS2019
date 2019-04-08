using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class DCloApiModel : ApiModel
    {
        public int DepartmentId { get; set; }
        public int CLO_ID { get; set; }
        public string Title { get; set; }
    }
}