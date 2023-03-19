using School.Infrastructure.DbContexts;
using School.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IStudentRepository Students { get; private set; }

        public ApplicationUnitOfWork(IApplicationDbContext dbContext,
            IStudentRepository studentRepository) : base((DbContext)dbContext)
        {
            Students = studentRepository;
        }
    }
}
