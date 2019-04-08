using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloasisWeb.ApiInfrastructure.ApiModels
{
    public class StatisticsByAssignmentApiModel
    {
        public int AssignmentId { get; set; }
        public int AssignmentTypeId { get; set; }
        public string AssignmentType { get; set; }
        public string Assignment { get; set; }
        public decimal MaxPoints { get; set; }
        public decimal Max { get; set; }
        public decimal MaxPrct { get; set; }
        public decimal Min { get; set; }
        public decimal MinPrct { get; set; }
        public decimal Average { get; set; }
        public decimal AveragePrct { get; set; }
    }
    public class StatisticsByQuestionApiModel
    {
        public int AssignmentPartId { get; set; }
        public int QuestionNumber { get; set; }
        public decimal MaxPoints { get; set; }
        public decimal Max { get; set; }
        public decimal MaxPrct { get; set; }
        public decimal Min { get; set; }
        public decimal MinPrct { get; set; }
        public decimal Average { get; set; }
        public decimal AveragePrct { get; set; }
    }
}