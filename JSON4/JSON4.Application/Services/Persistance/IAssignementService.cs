using JSON4.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4.Application.Services.Persistance
{
    public interface IAssignementService
    {
        Task<IEnumerable<Assignement>> GetAllAssignmentsAsync();
        Task<Assignement> GetAssignmentByIdAsync(int id);
        Task<IEnumerable<Assignement>> GetAssignmentsByEmployeeIdAsync(int employeeId);
        Task<IEnumerable<Assignement>> GetAssignmentsByProjectIdAsync(int projectId);
        Task AddAssignmentAsync(Assignement assignement);
        Task UpdateAssignmentAsync(Assignement assignement);
        Task DeleteAssignmentAsync(int id);
    }
}
