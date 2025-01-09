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
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDBContext _context;

        public EmployeeRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByDepartmentIdAsync(int departmentId)
        {
            return await _context.Employees
                                 .Where(e => e.DepartmentId == departmentId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesWithHighSalaryAsync(decimal minSalary)
        {
            return await _context.Employees
                                 .Where(e => e.Salary >= minSalary)
                                 .ToListAsync();
        }
    }
}
