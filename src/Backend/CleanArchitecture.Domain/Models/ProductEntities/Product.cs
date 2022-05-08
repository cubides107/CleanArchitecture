using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Models.ProductEntities
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        private Product(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public static Product Build(string name, string description)
        {
            return new Product(name, description);
        }
    }
}
