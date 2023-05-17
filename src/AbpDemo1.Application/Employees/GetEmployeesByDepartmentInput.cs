using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AbpDemo1.Employees
{
    public class GetEmployeesByDepartmentInput
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public List<MyEmployee> Employees { get; set; }
    }
}