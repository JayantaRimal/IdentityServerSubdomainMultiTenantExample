using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.AuthorizationPolicy
{
    public class TenantRequirement :IAuthorizationRequirement
    {

        public TenantRequirement()
        {


        }
    }
}
