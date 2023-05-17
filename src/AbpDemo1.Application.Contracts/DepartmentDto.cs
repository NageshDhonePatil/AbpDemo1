using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AbpDemo1.Employees;

namespace AbpDemo1
{
    public class DepartmentDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public List<MyEmployee> Employees { get; set; }
    }
}
