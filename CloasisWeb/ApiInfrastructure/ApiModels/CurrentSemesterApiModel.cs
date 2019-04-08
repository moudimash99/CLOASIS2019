using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class CurrentSemesterApiModel : ApiModel
    {
        public string CurrentYearId { get; set; }
        public string CurrentSemesterId { get; set; }
        public string SemesterTitle { get; set; }
        public string YearTitle { get; set; }
    }
}