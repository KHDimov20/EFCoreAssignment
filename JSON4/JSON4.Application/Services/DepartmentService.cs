using JSON4.Application.Services.Persistance;
using JSON4.Domain.Entities;
using JSON4.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _departmentRepository.GetAllAsync();
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            return await _departmentRepository.GetByIdAsync(id);
        }

        public async Task<Department> GetDepartmentByNameAsync(string name)
        {
            return await _departmentRepository.GetDepartmentByNameAsync(name);
        }

        public async Task<IEnumerable<Department>> GetDepartmentsWithBudgetGreaterThanAsync(decimal minBudget)
        {
            return await _departmentRepository.GetDepartmentsWithBudgetGreaterThanAsync(minBudget);
        }

        public async Task AddDepartmentAsync(Department department)
        {
            await _departmentRepository.AddAsync(department);
        }

        public async Task UpdateDepartmentAsync(Department department)
        {
            await _departmentRepository.UpdateAsync(department);
        }

        public async Task DeleteDepartmentAsync(int id)
        {
            await _departmentRepository.DeleteAsync(id);
        }
    }
}
