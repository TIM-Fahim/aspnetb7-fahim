using Microsoft.EntityFrameworkCore;
using School.Infrastructure.DbContexts;
using School.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
    public class StudentRepository : Repository<Student, Guid>, IStudentRepository
    {
        public StudentRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }
    }
}
