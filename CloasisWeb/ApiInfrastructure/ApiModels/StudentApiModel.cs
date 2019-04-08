using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class StudentApiModel : ApiModel
    {
        public int StudentID { get; set; }
        public int AUBID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Middle { get; set; }
        public string email { get; set; }
        public int IAN { get; set; }
        public string Picture { get; set; }
        public int RegisteredCourseID { get; set; }
        public int CourseOfferingID { get; set; }
        public string CourseTitle { get; set; }
        public string CourseNumber { get; set; }
        public string SemesterTitle { get; set; }
        public string YearTitle { get; set; }
        public string SectionNumber { get; set; }

    }
    public class StudentsRoot
    {
        public List<StudentApiModel> Courses { get; set; }
    }
}