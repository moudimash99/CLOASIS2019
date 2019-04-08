using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class AttendanceApiModel : ApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal KPI { get; set; }
        public string KPIText { get; set; }

    }
}