using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface IStatisticsClient
    {
        Task<List<StatisticsByAssignmentApiModel>> GetAllStatisticsByAssignment(int courseOfferingId);
        Task<List<StatisticsByQuestionApiModel>> GetAllStatisticsByQuestion(int assignmentId);
    }
}
