using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class AssignmentTypeApiModel : ApiModel
    {
        public int AssignmentTypeID { get; set; }
        public string AssignmentType { get; set; }
        public int DisplayOrder { get; set; }
        public object Assignments { get; set; }
        public object AssignmentType_Grade { get; set; }
        public object CourseGradeDistributions { get; set; } 

    }
}