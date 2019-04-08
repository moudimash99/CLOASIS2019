using CloasisWeb.ApiInfrastructure.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloasisWeb.ApiInfrastructure.Client.Interfaces
{
    public interface ICurrentSemesterClient
    {
        Task<List<CurrentSemesterApiModel>> GetAll();
    }
}
