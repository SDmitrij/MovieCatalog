using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MovieCatalog.Database;
using MovieCatalog.Database.Base;
using MovieCatalog.Database.Context;
using MovieCatalog.Database.Context.Base;
using MovieCatalog.Models;
using System.IO;

namespace MovieCatalog
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
            services.AddDbContext<Auth>(options => options.UseSqlite(Configuration.GetConnectionString("Auth")));
            services.AddDbContext<Catalog>(options => options.UseSqlite(Configuration.GetConnectionString("Catalog")));
            services.AddDefaultIdentity<User>().AddEntityFrameworkStores<Auth>();
            services.AddScoped<IContext, Auth>();
            services.AddScoped<IContext, Catalog>();
            services.AddScoped<IInteraction, Interaction>();
            services.AddHttpContextAccessor();
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
