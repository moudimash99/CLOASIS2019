using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class AssignmentsApiModel : ApiModel
    {
        public int AssignmentId { get; set; }
        public string AssignmentType { get; set; }
        public string AssignmentTitle { get; set; }
        public decimal MaxPoints { get; set; }
        public DateTime AssignmentDate { get; set; }
        public bool isGraded { get; set; }
        public bool isGroupAssignment { get; set; }

    }
    public class AssignmentsApiUpdateModel : ApiModel
    {
        public int AssignmentId { get; set; }
        public int AssignmentTypeId { get; set; }
        public string AssignmentType { get; set; }
        public int CourseOfferingId { get; set; }
        public string Title { get; set; } 
        public decimal MaxPoints { get; set; } // maybe integer
        public DateTime AssignmentDate { get; set; }
        public bool isGraded { get; set; }
        public bool isGroupAssignment { get; set; } 
        public float Weight { get; set; }
        public int DisplayOrder { get; set; }
        public string ShortTitle { get; set; }
        public int ParentAssignmentId { get; set; }
        public string GradeFormula { get; set; }  //better to be object

    }
    public class AssignmentsApiAddModel : ApiModel
    { 
        public int AssignmentTypeId { get; set; }
        public string AssignmentType { get; set; }
        public int CourseOfferingId { get; set; }
        public string Title { get; set; }
        public decimal MaxPoints { get; set; } // maybe integer
        public DateTime AssignmentDate { get; set; }
        public bool isGraded { get; set; }
        public bool isGroupAssignment { get; set; }
        public float Weight { get; set; }
        public int DisplayOrder { get; set; }
        public string ShortTitle { get; set; }
        public int ParentAssignmentId { get; set; }
        public string GradeFormula { get; set; }  //better to be object

    }
}