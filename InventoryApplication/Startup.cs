using InventoryApplication.Repository;
using InventoryApplication.Repository.RepositoryInterface;
using InventoryApplication.Services;
using InventoryApplication.Services.ServicesInterface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementData.HibernateHelper;

namespace InventoryApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation() ;
            services.AddSession();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromMinutes(30);//We set Time here 
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //});
            services.AddDistributedMemoryCache();
            services.AddHttpContextAccessor();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/User/Login";
                    options.Cookie.Name = "InventoryLoginCookie";

                });
            
            services.AddScoped<ProductServiceInterface, ProductService>();
            services.AddSingleton<SessionFactoryInterface, NHibernateHelper>();
            services.AddScoped<ProductRepositoryInterface, ProductRepository>();
            services.AddScoped<ProfileRepositoryInterface, ProfileRepository>();
            services.AddScoped<ProfileServiceInterface, ProfileService>();
            services.AddScoped<ProductEntryRepositoryInterface, ProductEntryRepository>();
            services.AddScoped<ProductEntryServiceInterface, ProductEntryService>();
            services.AddScoped<AccountRepositoryInterface, AccountRepository>();
            services.AddScoped<AccountServiceInterface, AccountService>();
            services.AddScoped<BillRepositoryInterface, BillRepository>();
            services.AddScoped<BillServiceInterface,BillService>();
            services.AddScoped<PaymentRepositoryInterface, PaymentRepository>();
            services.AddScoped<PaymentServiceInterface, PaymentService>();
            services.AddScoped<BillRepositoryInterface, BillRepository>();
            services.AddScoped<UserRepositoryInterface, UserRepository>();

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
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}");
            });
        }
    }
}
