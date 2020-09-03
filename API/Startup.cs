using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.AuthorizationPolicy;
using API.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        private readonly String MyAllowSpecificOrigins = "_myAllowSpecificOrgins";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();


            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {

                    builder.WithOrigins(Configuration.GetSection("CORS:Urls").Get<List<string>>().ToArray());
                    builder.WithHeaders("Authorization");
                    builder.WithHeaders("content-type");
                    builder.AllowAnyMethod();
                });
            });

            services.AddAuthorization(options=> {

                options.AddPolicy("Tenant", policy => policy.Requirements.Add(new TenantRequirement()));

            });

            //Add authentication

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options=> {

                    options.RequireHttpsMetadata = true;

                    //your authority, this will be base url for now as we have created dynamic authority according to the tenant

                    options.Authority = "https://jayanta.com:44318";

                    options.Audience = "web_api";
                
                
                });

           

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<TenantProvider>();

            services.AddSingleton<IOptionsMonitor<JwtBearerOptions>, JwtBearerOptionsProvider>();
            services.AddSingleton<IConfigureOptions<JwtBearerOptions>,JwtOptionsInitializer>();

            services.AddSingleton<IAuthorizationHandler, TenantHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors(MyAllowSpecificOrigins);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            
        }
    }
}
