using AbpDemo1.Employees;
using AutoMapper;

namespace AbpDemo1;

public class AbpDemo1ApplicationAutoMapperProfile : Profile
{
    public AbpDemo1ApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<MyEmployee, EmployeeDto>();
        CreateMap<CreateUpdateEmployeeDto, MyEmployee>();
       
    }
}
