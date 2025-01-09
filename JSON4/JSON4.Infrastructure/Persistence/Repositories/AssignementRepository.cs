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
    public class AssignementRepository : Repository<Assignement>, IAssignementRepository
    {
        private readonly ApplicationDBContext _context;

        public AssignementRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Assignement>> GetAssignementsByEmployeeIdAsync(int employeeId)
        {
            return await _context.Assignements
            .Where(a => a.EmployeeId == employeeId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Assignement>> GetAssignementsByProjectIdAsync(int projectId)
        {
            return await _context.Assignements
                                 .Where(a => a.ProjectId == projectId)
                                 .ToListAsync();
        }
    }
}
