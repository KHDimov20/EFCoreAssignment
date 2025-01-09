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
    public class AssignmentService : IAssignementService
    {
        private readonly IAssignementRepository _assignementRepository;

        public AssignmentService(IAssignementRepository assignementRepository)
        {
            _assignementRepository = assignementRepository;
        }

        public async Task<IEnumerable<Assignement>> GetAllAssignmentsAsync()
        {
            return await _assignementRepository.GetAllAsync();
        }

        public async Task<Assignement> GetAssignmentByIdAsync(int id)
        {
            return await _assignementRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Assignement>> GetAssignmentsByEmployeeIdAsync(int employeeId)
        {
            return await _assignementRepository.GetAssignementsByEmployeeIdAsync(employeeId);
        }

        public async Task<IEnumerable<Assignement>> GetAssignmentsByProjectIdAsync(int projectId)
        {
            return await _assignementRepository.GetAssignmentsByProjectIdAsync(projectId);
        }

        public async Task AddAssignmentAsync(Assignement assignement)
        {
            await _assignementRepository.AddAsync(assignement);
        }

        public async Task UpdateAssignmentAsync(Assignement assignement)
        {
            await _assignementRepository.UpdateAsync(assignement);
        }

        public async Task DeleteAssignementAsync(int id)
        {
            await _assignementRepository.DeleteAsync(id);
        }
    }
}
