using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4.Domain.Entities
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
         
        public string Name { get; set; }
         
        public string Location { get; set; }

        public decimal Budget { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
