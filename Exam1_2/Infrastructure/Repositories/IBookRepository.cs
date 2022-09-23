using Exam1_2.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2.Infrastructure.Repositories
{
    public interface IBookRepository : IRepository<Book, Guid>
    {
        (IList<Book> data, int total, int totalDisplay) GetCourses(int pageIndex,
            int pageSize, string searchText, string orderby);
    }
}
