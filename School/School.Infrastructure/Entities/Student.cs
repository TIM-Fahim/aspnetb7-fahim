using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Entities
{
    public class Student
    {
        int ID { get; set; }
        string Name { get; set; }

        DateOnly DateOfBirth { get; set; }
        string? Email { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }

        decimal CGPA { get; set; }

    }
}
