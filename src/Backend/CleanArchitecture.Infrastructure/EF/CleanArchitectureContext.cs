using CleanArchitecture.Domain.Models.ProductEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.EF
{
    public class CleanArchitectureContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        public CleanArchitectureContext(DbContextOptions<CleanArchitectureContext> options) : base(options)
        {

        }
    }


}
