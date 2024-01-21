using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartment.Models
{
    public class Employee: BaseModel
    {
        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Date Of Joining")]
        public DateTime DOJ { get; set; }

        [Required]  
        public decimal Salary { get; set; }

        [StringLength(500)]
        public string Address  { get; set; }

        public Department Department { get; set; }
    }
}