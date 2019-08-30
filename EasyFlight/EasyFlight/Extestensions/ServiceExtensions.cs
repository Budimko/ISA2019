using EasyFlight.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Extestensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepoWrapper, RepoWrapper>();//vidis ovo AddScoped
            //e to ti znaci da ce instanca RepoWrapper da zivi koliko i traje jedan request
            //sto znaci kad neko pogodi kontroler i dok ne doje do kraja kontrolera, tad treba da otvoris konkciju i na kraju da je zatvoris
            //a to sve ti je sad u RepoWrapper, on ce sadrzati reference ka ostalim repoima
        }
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration Configuration)
        {
            var connectionString = Configuration["sqlserverconnection:ConnectionStr"];
            services.AddDbContext<DBContext>(o => o.UseSqlServer(connectionString));
        }

    }
}
