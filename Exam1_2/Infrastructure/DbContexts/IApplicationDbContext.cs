using Exam1_2.Infrastructure.BusinessObjects;
using Exam1_2.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Book = Exam1_2.Infrastructure.Entities.Book;
using Reader = Exam1_2.Infrastructure.Entities.Reader;

namespace Exam1_2.Infrastructure.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Reader> Readers { get; set; }
    }
}