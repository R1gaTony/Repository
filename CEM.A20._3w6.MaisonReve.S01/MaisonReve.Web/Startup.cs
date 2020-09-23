using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaisonReve.Database.Context;
using MaisonReve.Database.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MaisonReve.Database.Models;

namespace MaisonReve.Web
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
            //Ajouter les vues et controlleurs au DI
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddDbContext<MaisonReveDbContext>(options => 
                    {
                    options.UseSqlServer(Configuration.GetConnectionString("MaisonReveDbContext"));
                    });


            //Ajout de singleton
            services.AddSingleton<IRentTermConverter, RentTermConverter>();

            services.AddScoped<IBuildingRepo, BuildingRepo>();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
