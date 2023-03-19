using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Entities
{
    //When we create a new entity, we need to implement this interface
    public interface IEntity<T>
    {
        T ID { get; set; }
    }
}
