using Exam1_2.Infrastructure.DbContexts;
using Exam1_2.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure.Repositories
{
    public class BookRepository : Repository<Book, Guid>, IBookRepository
    {
        public BookRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }

        public (IList<Book> data, int total, int totalDisplay) GetBooks(int pageIndex,
            int pageSize, string searchText, string orderby)
        {
            (IList<Book> data, int total, int totalDisplay) results = 
                GetDynamic(x => x.Title.Contains(searchText), orderby,
                "Title,BookReader", pageIndex, pageSize, true);

            return results;
        }
    }
}
