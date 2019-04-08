using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class COUCloApiModel : ApiModel
    {
        public int CourseOfferingId { get; set; }
        public string CLO { get; set; }
        public decimal Units { get; set; }
    }
}