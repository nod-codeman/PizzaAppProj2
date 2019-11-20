using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Identity
{
    public class AppUser : IdentityUser
    {
        public string MyExtraProperty { get; set; }
    }
}
