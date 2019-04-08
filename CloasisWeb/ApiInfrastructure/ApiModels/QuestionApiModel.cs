using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class QuestionApiAddModel : ApiModel
    {
        public int AssignmentID { get; set; }
        public string Title { get; set; }
        public decimal QuestionNumber { get; set; }
        public decimal MaxPoints { get; set; }
        public DateTime AssignmentDate { get; set; }
        public decimal Weight { get; set; }
        public bool isGraded { get; set; }
        public string QuestionPaperNumber { get; set; }
    }
    public class QuestionApiUpdateModel : ApiModel
    {
        public int AssignmentPartId { get; set; }
        public decimal AssignmentID { get; set; }
        public string Title { get; set; }
        public decimal QuestionNumber { get; set; }
        public decimal MaxPoints { get; set; }
        public DateTime AssignmentDate { get; set; }
        public decimal Weight { get; set; }
        public bool isGraded { get; set; }
        public string QuestionPaperNumber { get; set; }
    }
    public class QuestionApiModel : ApiModel
    {
        public int AssignmentPartID { get; set; }
        public int AssignmentID { get; set; }
        public string Title { get; set; }
        public decimal QuestionNumber { get; set; }
        public decimal MaxPoints { get; set; }
        public DateTime AssignmentDate { get; set; }
        public decimal Weight { get; set; }
        public bool isGraded { get; set; }
        public string QuestionPaperNumber { get; set; }
        //public object AssignmentPart_CLOs { get; set; }
        public object Assignment { get; set; }
        //public object AssignmentPart_Grade { get; set; }
 
    }
}