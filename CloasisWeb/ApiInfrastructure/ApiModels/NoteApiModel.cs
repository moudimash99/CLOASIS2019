using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class NoteApiModel : ApiModel
    {
        public int StudentCommentID { get; set; }
        public int StudentID { get; set; }
        public int InstructorId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CourseOffering { get; set; }
        public string Instructor { get; set; }
        public string Student { get; set; } 

    }
}