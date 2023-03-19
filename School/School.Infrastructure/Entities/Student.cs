﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Entities
{
    public class Student : IEntity<Guid>
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public double CGPA { get; set; }

    }
}
