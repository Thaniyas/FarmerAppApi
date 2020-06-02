using ThaniyasFarmerAppAPI.Authentication;
using ThaniyasFarmerAppAPI.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;
using Swashbuckle.AspNetCore.Swagger;
using ThaniyasFarmerAppAPI.Services;
using ThaniyasFarmerAppAPI.Services.Interfaces;
using ThaniyasFarmerAppAPI.Filters;
using ThaniyasFarmerAppAPI.Helpers;
using System.Linq;

namespace ThaniyasFarmerAppAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<BaseDbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:ThaniyasFarmerAppDB"]));
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc()
                    .AddJsonOptions(
                        options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    );
            services.AddCors(options => { options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials()); });
            services.AddSingleton(Configuration);
           // services.AddAuthenticationAndAuthorization();
            
            AppSettings.UserID = Configuration["UserID"];
            AppSettings.Password = Configuration["Password"];
            AppSettings.SMTPPort = Configuration["SMTPPort"];
            AppSettings.Host = Configuration["Host"];

            services.AddTransient<IAccountsServices, AccountsServices>();
            services.AddTransient<IUserActivityServices, UserActivityServices>();
            services.AddTransient<IEmailService, EmailService>();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                //c.AddSecurityDefinition("api-key-value",
                //new ApiKeyScheme
                //{
                //    In = "header",
                //    Description = "Please enter into field the word 'Bearer' following by space and your token.",
                //    Name = "Authorization",
                //    Type = "apiKey"
                //});
            });
            
            services.AddScoped<ActionFilter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseCors("CorsPolicy");

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "default",
                   template: "{controller}/{action=Index}/{id?}");
            });
            app.UseAuthentication();            
            app.UseMvc();

            //app.UseCors();
            
        }
    }
}
