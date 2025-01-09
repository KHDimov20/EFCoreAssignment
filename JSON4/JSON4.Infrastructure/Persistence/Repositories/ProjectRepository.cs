using JSON4.Domain.Entities;
using JSON4.Domain.Interfaces;
using JSON4.Infrastructure.Persistence.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4.Infrastructure.Persistence.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        private readonly ApplicationDBContext _context;

        public ProjectRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> GetActiveProjectsAsync()
        {
            return await _context.Projects
                                 .Where(p => p.EndDate >= DateTime.Now)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Project>> GetProjectsByBudgetAsync(decimal minBudget, decimal maxBudget)
        {
            return await _context.Projects
                                 .Where(p => p.Budget >= minBudget && p.Budget <= maxBudget)
                                 .ToListAsync();
        }
    }
}
