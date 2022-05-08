using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models.ProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ProductServices
{

    public class ProductServices
    {
        private readonly IRepository repository;

        public ProductServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Register(Product product)
        {
            await repository.Save(product);
            await repository.Commit();
        }
    }
}
