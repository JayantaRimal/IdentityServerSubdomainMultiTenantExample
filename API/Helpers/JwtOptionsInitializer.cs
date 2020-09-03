using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class JwtOptionsInitializer : IConfigureNamedOptions<JwtBearerOptions>
    {
        private readonly TenantProvider _tenantProvider;

        public JwtOptionsInitializer(TenantProvider tenantProvider)
        {
            _tenantProvider = tenantProvider;
        }

        public void Configure(string name,JwtBearerOptions options)
        {

            var authority = _tenantProvider.GetCurrentTenant();
            options.RequireHttpsMetadata = true;
            options.Authority = authority;
        }

        public void Configure(JwtBearerOptions options)
            => Debug.Fail("This infrastructure method should'nt be called.");


    }

}
