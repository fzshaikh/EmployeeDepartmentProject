using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartment.Models
{
    public class Department: BaseModel
    {
        [Required]
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }

    }
}