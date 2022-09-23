﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure.Entities
{
    public class Reader : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
        public List<ReaderRegistration> ReaderBooks { get; set; }
    }
}