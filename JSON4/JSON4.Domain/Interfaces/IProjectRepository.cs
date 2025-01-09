using JSON4.Domain.Entities;
using JSON4.Domain.Interfaces.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4.Domain.Interfaces
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<IEnumerable<Project>> GetActiveProjectsAsync();
        Task<IEnumerable<Project>> GetProjectsByBudgetAsync(decimal minBudget, decimal maxBudget);
    }
}
