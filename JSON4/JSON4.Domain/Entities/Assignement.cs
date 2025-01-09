using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4.Domain.Entities
{
    public class Assignement
    {
        [Key]
        public int AssignementId { get; set; }
         
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
         
        public int ProjectId { get; set; }

        public Project Project { get; set; }
         
        public int HoursWorked { get; set; }
         
        public string Role { get; set; }
    }
}
