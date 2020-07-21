using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.EFModel
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? DepartmentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public Department Department { get; set; }
    }
}
