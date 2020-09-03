using IdentityServer.Models;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IUserClaimsPrincipalFactory<ApplicationUser> _claimsFactory;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _context;

        public ProfileService (IHttpContextAccessor context, UserManager<ApplicationUser> userManager, IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory)
        {
            _context = context;
            _userManager = userManager;
            _claimsFactory = claimsFactory;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);
            var principal = await _claimsFactory.CreateAsync(user);

            var claims = principal.Claims.ToList();
            claims = claims.Where(claim => context.RequestedClaimTypes.Contains(claim.Type)).ToList();

            //Add custom claims in the token here
            claims.Add(new Claim("TenantId", user.TenantId ?? string.Empty));
            context.IssuedClaims = claims;
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);

            if(context.Caller == "AuthorizeEndpoit")
            {
                var tenantId = _context.HttpContext.Request.Query["acr_values"].ToString().Replace("tenant:", "");
                if(user!=null && !string.IsNullOrEmpty(tenantId)&&tenantId==user.TenantId)
                {
                    context.IsActive = true;
                }
                else
                {
                    context.IsActive = false;
                }
            }
            else
            {
                context.IsActive = user != null;
            }
        }


    }
}
