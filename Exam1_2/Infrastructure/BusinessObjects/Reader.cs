using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure.BusinessObjects
{
    public class Reader
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Balance { get;set; }
        public DateTime JoiningDate { get; set; }

        public void SetJoiningDate()
        {
            if (JoiningDate.Subtract(DateTime.Now).TotalDays < 30)
                JoiningDate = DateTime.Now.AddDays(30);
        }
    }
}
