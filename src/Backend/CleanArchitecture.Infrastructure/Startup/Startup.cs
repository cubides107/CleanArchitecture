using CleanArchitecture.Infrastructure.EF;
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
        }

        public static void ConfigureContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CleanArchitectureContext>(options => options.UseSqlServer(configuration.GetConnectionString("ArchitectureContext")));
        }

    }
}
