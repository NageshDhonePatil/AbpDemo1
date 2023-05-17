using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpDemo1.Employees
{
    public class CreateUpdateEmployeeDto
    {

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; } 

        [Required]
         public int DepartmentId { get; set; } 

        [Required]
        [StringLength(128)]
        public string? Department { get; set; }
    }
}
