using JSON4.Domain.Entities;
using JSON4.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4.Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await _projectRepository.GetAllAsync();
        }

        public async Task<Project> GetProjectByIdAsync(int id)
        {
            return await _projectRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Project>> GetActiveProjectsAsync()
        {
            return await _projectRepository.GetActiveProjectsAsync();
        }

        public async Task<IEnumerable<Project>> GetProjectsByBudgetAsync(decimal minBudget, decimal maxBudget)
        {
            return await _projectRepository.GetProjectsByBudgetAsync(minBudget, maxBudget);
        }

        public async Task AddProjectAsync(Project project)
        {
            await _projectRepository.AddAsync(project);
        }

        public async Task UpdateProjectAsync(Project project)
        {
            await _projectRepository.UpdateAsync(project);
        }

        public async Task DeleteProjectAsync(int id)
        {
            await _projectRepository.DeleteAsync(id);
        }
    }
}
