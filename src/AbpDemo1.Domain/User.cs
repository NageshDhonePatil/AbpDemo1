using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;

namespace AbpDemo1
{
    public class User:IdentityUser
    {
        public string UserName { get; set; }

       public string Password { get; set; }

    }
}
