using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        protected Entity(Guid? id = null)
        {
            Id = id != null ? id.Value : Guid.NewGuid();
        }
    }
}
