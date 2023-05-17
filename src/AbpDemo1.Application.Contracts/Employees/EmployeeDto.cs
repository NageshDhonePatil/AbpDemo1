using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpDemo1.Employees
{
    public class EmployeeDto : EntityDto<Guid>
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public int? DepartmentId { get; set; }

        public virtual DepartmentDto Department { get; set; }


    }
}
