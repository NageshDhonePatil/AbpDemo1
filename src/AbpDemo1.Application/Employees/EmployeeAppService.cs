using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using static Volo.Abp.Identity.IdentityPermissions;

namespace AbpDemo1.Employees
{
    public class EmployeeAppService : ApplicationService
    {
     

        private readonly IRepository<MyEmployee> _employeeRepository;

        public EmployeeAppService(IRepository<MyEmployee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Authorize(Roles = RoleConsts.HR)]
        public async Task CreateEmployee(CreateUpdateEmployeeDto input)
        {
            var employee = ObjectMapper.Map<CreateUpdateEmployeeDto, MyEmployee>(input);
            await _employeeRepository.InsertAsync(employee);
            await CurrentUnitOfWork.SaveChangesAsync();
        }

        [Authorize(Roles = RoleConsts.HR)]
        public async Task UpdateEmployee  (CreateUpdateEmployeeDto input)
        {
            var employeeQuery = await _employeeRepository.GetQueryableAsync();
            var employee = employeeQuery.FirstOrDefault(x => x.Id == input.Id);


           
            ObjectMapper.Map(input, employee);
        }

        [Authorize(Roles = RoleConsts.HR)]
        public async Task DeleteEmployee(EntityDto<int>  input)
        {
            var employeeQuery = await _employeeRepository.GetQueryableAsync();
            var employee = employeeQuery.FirstOrDefault(x => x.Id == input.Id);
            await _employeeRepository.DeleteAsync(employee);
         

        }

        [Authorize(Roles = RoleConsts.HR)]
        public async Task<EmployeeDto> GetEmployee(EntityDto<int> input)
        {
            var employeeQuery = await _employeeRepository.GetQueryableAsync();
            var employee = employeeQuery.FirstOrDefault(x => x.Id == input.Id);

       
             return ObjectMapper.Map<MyEmployee, EmployeeDto>(employee);
        }


    }
}