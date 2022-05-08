using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class SQLServerRepository : IRepository
    {
        protected readonly CleanArchitectureContext context;

        public SQLServerRepository(CleanArchitectureContext context)
        {
            this.context = context;
        }

        public async Task Commit()
        {
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}");
            }
        }

        public async Task Save<T>(T obj) where T : Entity
        {
            {
                try
                {
                    await context.Set<T>().AddAsync(obj);
                }
                catch (Exception e)
                {
                    throw new Exception($"{e.Message}");
                }
            }
        }
    }
}
