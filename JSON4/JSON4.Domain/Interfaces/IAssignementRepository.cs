using JSON4.Domain.Entities;
using JSON4.Domain.Interfaces.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4.Domain.Interfaces
{
    public interface IAssignementRepository : IRepository<Assignement>
    {
        Task<IEnumerable<Assignement>> GetAssignementsByEmployeeIdAsync(int employeeId);
        Task<IEnumerable<Assignement>> GetAssignementsByProjectIdAsync(int projectId);
    }
}
