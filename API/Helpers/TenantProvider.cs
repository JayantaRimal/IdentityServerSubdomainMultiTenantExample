using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class TenantProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IConfiguration Configuration { get; }

        public TenantProvider(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        { 
            
            _httpContextAccessor = httpContextAccessor;
            Configuration = configuration;

        }

        public string GetCurrentTenant()
        {
            string requestUrl = $"{this._httpContextAccessor.HttpContext.Request.Host}";
            var tenantId = requestUrl.Split('.')[0];
            string authorityDomain = Configuration.GetValue<string>("AuthorizationServerUrls:AuthorityDomain");
            string authorityScheme = Configuration.GetValue<string>("AuthorizationServerUrls:AuthorityScheme");
            string authorityUrl = $"{authorityScheme}://{tenantId}.{authorityDomain}";

            return authorityUrl;
        }

    }
}
