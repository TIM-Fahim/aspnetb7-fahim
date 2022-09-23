using Autofac;
using Exam1_2.Infrastructure.BusinessObjects;
using Exam1_2.Infrastructure.Services;
using System.ComponentModel.DataAnnotations;

namespace Exam1_2.Areas.Admin.Models
{
    public class BookCreateModel : BaseModel
    {
        [Required]
        public string Title { get; set; }
        public bool Available { get; set; }
        public DateTime PublishDate { get; set; }

        private IBookService? _bookService;

        public BookCreateModel() : base()
        {

        }

        public BookCreateModel(IBookService coursService)
        {
            _bookService = coursService;
        }

        public override void ResolveDependency(ILifetimeScope scope)
        {
            base.ResolveDependency(scope);
            _bookService = _scope.Resolve<IBookService>();
        }

        internal async Task CreateBook()
        {
            Book book = new Book();
            book.Name = Title;
            book.Availble = Available;
            book.PublicationDate = PublishDate;

            _bookService.CreateBook(book);
        }
    }
}
