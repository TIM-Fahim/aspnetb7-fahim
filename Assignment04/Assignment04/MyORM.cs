using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    public class MyORM<G, T>
    {
        public void Insert(T item)
        { 
        
        }
        public void Update(T item)
        {

        }
        public void Delete(T item)
        {

        }
        public void Delete(G id)
        { 
        
        }
        public Course GetById(G id)
        {
            return new Course();
;        }
        public List<Course> GetAll()
        {
            return null;
        }
    }
}
