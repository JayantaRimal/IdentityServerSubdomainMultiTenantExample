using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.AuthorizationPolicy
{
    public class TenantHandler : AuthorizationHandler<TenantRequirement>
    {
        private readonly IHttpContextAccessor _context;

        public TenantHandler(IHttpContextAccessor context)
        {
            _context = context;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, TenantRequirement requirement)
        {

            if (!context.User.HasClaim(c => c.Type == "TenantId")||!context.User.HasClaim(c=>c.Type=="iss"))
            {

                return Task.CompletedTask;
            }

            var tenantId = context.User.Claims.Where(x => x.Type == "TenantId").FirstOrDefault().Value;
            var requestUrl = $"{_context.HttpContext.Request.Host }";

            var requestTenantId = requestUrl.Split('.')[0];
            if(string.IsNullOrEmpty(tenantId)||string.IsNullOrEmpty(requestTenantId)||tenantId!=requestTenantId)
            {
                return Task.CompletedTask;
            }

            var issuer = context.User.FindFirst(x => x.Type == "iss").Value;
            var issuerTenant = new Uri(issuer).Host.Split('.')[0];

            if(string.IsNullOrEmpty(issuerTenant)||issuerTenant!=tenantId)
            {
                return Task.CompletedTask;

            }

            context.Succeed(requirement);

            return Task.CompletedTask;


        }

    }
}
