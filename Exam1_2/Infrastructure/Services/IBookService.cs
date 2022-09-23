using Exam1_2.Infrastructure.BusinessObjects;

namespace Exam1_2.Infrastructure.Services
{
    public interface IBookService
    {
        void CreateBook(Book course);
        (int total, int totalDisplay, IList<Book> records) GetCourses(int pageIndex, int pageSize, string searchText, string orderby);
    }
}