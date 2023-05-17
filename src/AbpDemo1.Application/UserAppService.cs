using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Volo.Abp.Identity.IdentityPermissions;
using static Volo.Abp.Identity.Settings.IdentitySettingNames;
using Volo.Abp.Application.Services;
using Microsoft.AspNet.Identity;
using Volo.Abp.Identity;

namespace AbpDemo1
{
    public class UserAppService : ApplicationService
    {
        private readonly IdentityUserManager _userManager;


        public UserAppService(IdentityUserManager userManager)
        {
            _userManager = userManager;
        }

     
        public async Task AddUserWithHRRole(UserDto userDto)
        {
            var user = ObjectMapper.Map<UserDto, User>(userDto);
            await _userManager.CreateAsync(user);
            await _userManager.AddToRoleAsync(user, RoleConsts.HR);
        }
    }

}
