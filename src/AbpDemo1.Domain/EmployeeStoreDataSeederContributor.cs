using AbpDemo1.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AbpDemo1
{
    public class EmployeeStoreDataSeederContributor
     : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<MyEmployee, int> _employeeRepository;

        public EmployeeStoreDataSeederContributor(IRepository<MyEmployee, int> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _employeeRepository.GetCountAsync() <= 0)
            {
                await _employeeRepository.InsertAsync(
                    new MyEmployee
                    {
                        Name = "Mahesh",
                       Email="Ash@123",
                       DepartmentId= 1,
                      // Department="HR"
                    },
                    autoSave: true
                );

                await _employeeRepository.InsertAsync(
                    new MyEmployee
                    {
                        Name = "Ganesh",
                        Email = "Gsh@123",
                        DepartmentId = 2,
                       // Department = "Admin"
                    },
                    autoSave: true
                );
            }
        }
    }
}
