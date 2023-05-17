using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpDemo1.Employees
{
    //public class MyEmployee : AuditedAggregateRoot<Guid>
    public class MyEmployee : Entity<int>
    {

        public string? Name { get; set; }

        public string? Email { get; set; }

      
        public int? DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }


    }

    public class Department
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public List<MyEmployee> Employees { get; set; }
    }
}

