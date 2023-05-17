using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace AbpDemo1
{
    public class MyEmployee
    {
        public string? Name { get; set; }

        public string? Email { get; set; }


        public int? DepartmentId { get; set; }

    }
}