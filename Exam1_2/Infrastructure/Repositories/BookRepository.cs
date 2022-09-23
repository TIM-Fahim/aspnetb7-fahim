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

        public (IList<Course> data, int total, int totalDisplay) GetCourses(int pageIndex,
            int pageSize, string searchText, string orderby)
        {
            (IList<Course> data, int total, int totalDisplay) results = 
                GetDynamic(x => x.Title.Contains(searchText), orderby,
                "Topics,CourseStudents", pageIndex, pageSize, true);

            return results;
        }
    }
}
