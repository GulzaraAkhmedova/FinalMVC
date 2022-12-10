using FinallyMVC.Domain.AppCode.Services;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities.Membership;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace FinallyMVC.WebUI
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("cString"));
            });
            services.AddIdentity<FinallymvcUser, FinallymvcRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            //https://docs.fluentvalidation.net/en/latest/aspnet.html


            services.AddScoped<UserManager<FinallymvcUser>>();
            services.AddScoped<SignInManager<FinallymvcUser>>();
            services.AddScoped<RoleManager<FinallymvcRole>>();


            services.Configure<AntiforgeryOptions>(cfg =>
            {
                cfg.Cookie.Name = "Finaly-ant";
            });

            services.Configure<CryptoServiceOptions>(cfg =>
            {
                configuration.GetSection("cryptograpy").Bind(cfg);
            });
            services.AddSingleton<ICryptoService, CryptoService>();

            services.Configure<EmailServiceOptions>(cfg =>
            {
                configuration.GetSection("emailAccount").Bind(cfg);
            });
            services.AddSingleton<IEmailService, EmailService>();

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            var assemblies = AppDomain.CurrentDomain
               .GetAssemblies()
               .Where(a => a.FullName.StartsWith("FinallyMVC."))
               .ToArray();

            services.AddMediatR(assemblies);

            //https://docs.fluentvalidation.net/en/latest/aspnet.html

            services.AddValidatorsFromAssemblies(assemblies, ServiceLifetime.Singleton);

            services.AddAuthentication();
            services.AddAuthorization();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.SeedMembership();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(name: "defaultAdmin",
                    areaName: "Admin",
                    pattern: "admin/{controller=home}/{action=index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
