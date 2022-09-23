using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure.Entities
{
    public class ReaderRegistration
    {
        public Guid MemberID { get; set; }
        public Reader Book { get; set; }
        public Guid StudentId { get; set; }
        public Reader Student { get; set; }
    }
}
