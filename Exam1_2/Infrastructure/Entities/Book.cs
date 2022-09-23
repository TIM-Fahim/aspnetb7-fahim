using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure.Entities
{
    public class Book : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool Available { get; set; }
        public DateTime PublicationDate { get; set; }
        
        public List<ReaderRegistration> BookReader { get; set; }
    }
}
