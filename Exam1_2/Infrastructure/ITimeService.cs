using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure
{
    public interface ITimeService
    {
        DateTime Now { get; }
    }
}
