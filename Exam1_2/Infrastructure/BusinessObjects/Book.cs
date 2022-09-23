using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure.BusinessObjects
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Availble { get;set; }
        public DateTime PublicationDate { get; set; }

        
    }
}
