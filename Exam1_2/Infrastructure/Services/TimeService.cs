using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure.Services
{
    public class TimeService : ITimeService
    {
        public DateTime Now 
        { 
            get => DateTime.UtcNow; 
        }
    }
}
