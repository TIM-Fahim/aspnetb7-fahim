using Exam1_2.Infrastructure.DbContexts;
using Exam1_2.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IBookRepository Books { get; private set; }

        public ApplicationUnitOfWork(IApplicationDbContext dbContext,
            IBookRepository bookRepository) : base((DbContext)dbContext)
        {
            Books = BookRepository;
        }
    }
}
