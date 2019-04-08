using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class GradeApiModel : ApiModel
    {
        public int CourseID { get; set; }
        public int CourseOfferingId { get; set; }
        public int StudentID { get; set; }
        public int IAN { get; set; }
        public int AUBID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentName { get; set; }


        public bool Leaderboard { get; set; }
        public int AssignmentTypeID { get; set; }
        public string AssignmentType { get; set; }
        public int AssignmentTypeDisplayOrder { get; set; }
        public int AssignmentID { get; set; }
        public string Assignment { get; set; }
        public int AssignmentDisplayOrder { get; set; } 
        public DateTime AssignmentDate { get; set; }


        public int GradeID { get; set; }
        public int Grade { get; set; }
        public int MaxPoints { get; set; }
        public float NormalizedGrade { get; set; }
        public float Weight { get; set; }
        public float WeightedSumGrade { get; set; }
        public float AssignmentTypeGrade { get; set; }
        public float AssignmentTypeWeight { get; set; }


        public float AssignmentOverallContributions { get; set; }
        public float AssignmentTypeOverallContributions { get; set; }
        public float Total { get; set; }
        public int MaxTotal { get; set; }


        public int AssignmentRank { get; set; }
        public object Comments { get; set; }
        public int FinalGrade { get; set; }
        public int AssignmentTypeRank { get; set; }
        public int ClassRank { get; set; }

    }
}

   