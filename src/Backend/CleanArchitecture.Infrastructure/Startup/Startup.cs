using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.EF;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Startup
{
    public class Startup
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureContext(services, configuration);
            ConfigureDependencyInjection(services);
        }

        /// <summary>
        /// Metodo para configurar el contexto
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void ConfigureContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CleanArchitectureContext>(options => options.UseSqlServer(configuration.GetConnectionString("ArchitectureContext")));
        }

        /// <summary>
        /// Metodo para configurar la injeccion de dependencias
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IRepository, SQLServerRepository>();
        }

    }
}
