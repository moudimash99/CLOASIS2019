using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class CourseApiModel : ApiModel
    {  
        public int CourseOfferingId { get; set; }
        public string CourseInstance { get; set; }
        public int YearId { get; set; }
        public string Year { get; set; }
        public int CourseID { get; set; }
        public string CourseNumber { get; set; }
        public int InstructorId { get; set; }
        public string Instructor { get; set; }
        public int SemesterID { get; set; }
        public string Title { get; set; }

    }

    public class CoursesRoot
    {
        public List<CourseApiModel> Courses { get; set; }
    }
}