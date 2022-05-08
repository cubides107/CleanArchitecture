using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IRepository
    {
        public Task Save<T>(T obj) where T : Entity;

        public Task Commit();
    }
}
