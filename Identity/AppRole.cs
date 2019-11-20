using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Identity
{
    public class AppRole : IdentityUser
    {
        public AppRole() : base() { }
        public AppRole(string name) : base(name) { }
    }
}
