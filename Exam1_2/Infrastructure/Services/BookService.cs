using Exam1_2.Infrastructure.DbContexts;
using Exam1_2.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exam1_2.Infrastructure.Services
{
    public class BookService : IBookService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;

        public BookService(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public void CreateBook(BookBO book)
        {
            

            BookEO bookEntity = new BookEO();
            bookEntity.Title = book.Name;
            bookEntity.Available = book.Availble;
            bookEntity.PublicationDate = book.PublicationDate;

            _applicationUnitOfWork.Books.Add(courseEntity);
            _applicationUnitOfWork.Save();
        }

        public (int total, int totalDisplay, IList<BookBO> records) GetBooks(int pageIndex,
            int pageSize, string searchText, string orderby)
        {
            (IList<BookEO> data, int total, int totalDisplay) results = _applicationUnitOfWork
                .Book.GetBooks(pageIndex, pageSize, searchText, orderby);

            IList<BookBO> books = new List<BookBO>();
            foreach (BookEO bookEO in results.data)
            {
                books.Add(new BookBO
                {
                    Id = bookEO.Id,
                    Name = bookEO.Title,
                    Availble = bookEO.Available,
                    PublicationDate = bookEO.PublicationDate
                });
            }

            return (results.total, results.totalDisplay, books);
        }
    }
}
