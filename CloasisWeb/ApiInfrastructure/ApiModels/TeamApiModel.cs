using ApiHelper.Model; 

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class TeamApiModel : ApiModel
    {
         public int TeamID { get; set; }
         public string Title { get; set; }
    }
    public class TeamApiAddModel : ApiModel
    { 
        public int CourseOfferingId { get; set; }
        public int DisplayOrder { get; set; }
        public string Title { get; set; }
    }
    public class TeamApiMembersModel : ApiModel
    {
        public int TeamMemberID { get; set; }
        public int TeamID { get; set; }
        public string Team { get; set; }
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public int CourseOfferingId { get; set; }
        public string Picture { get; set; } 
    }
}