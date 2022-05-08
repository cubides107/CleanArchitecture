using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class SQLServerRepository : IRepository
    {
        public Task Save<T>(T obj) where T : Entity
        {
            throw new NotImplementedException();
        }
    }
}
