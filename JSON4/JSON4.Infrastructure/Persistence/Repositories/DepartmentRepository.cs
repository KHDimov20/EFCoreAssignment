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
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly ApplicationDBContext _context;

        public DepartmentRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Department> GetDepartmentByNameAsync(string name)
        {
            return await _context.Departments
                                 .FirstOrDefaultAsync(d => d.Name == name);
        }

        public async Task<IEnumerable<Department>> GetDepartmentsWithBudgetGreaterThanAsync(decimal minBudget)
        {
            return await _context.Departments
                                 .Where(d => d.Budget > minBudget)
                                 .ToListAsync();
        }
    }
}
