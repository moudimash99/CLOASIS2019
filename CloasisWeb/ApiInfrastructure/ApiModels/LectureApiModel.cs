using ApiHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class LectureApiModel : ApiModel
    {
        public int LectureId { get; set; }
        public int CourseOfferingId { get; set; }
        public DateTime LectureDate { get; set; }
        public int LectureNumber { get; set; }
        public object CourseOffering { get; set; }
        public int[] Lecture_Topics { get; set; }
        public int[] LectureNotes { get; set; }
    }
    public class LectureApiAddModel : ApiModel
    {
        public int CourseOfferingId { get; set; }
        public DateTime LectureDate { get; set; }
        public int LectureNumber { get; set; }
    }
    public class LectureApiEditModel : ApiModel
    {
        public int CourseOfferingId { get; set; }
        public DateTime LectureDate { get; set; }
        public int LectureNumber { get; set; }
        public int LectureId { get; set; }
    }
}