using JSON4.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4.Application.Services.Persistance
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllProjectsAsync();
        Task<Project> GetProjectByIdAsync(int id);
        Task<IEnumerable<Project>> GetActiveProjectsAsync();
        Task<IEnumerable<Project>> GetProjectsByBudgetAsync(decimal minBudget, decimal maxBudget);
        Task AddProjectAsync(Project project);
        Task UpdateProjectAsync(Project project);
        Task DeleteProjectAsync(int id);
    }
}
