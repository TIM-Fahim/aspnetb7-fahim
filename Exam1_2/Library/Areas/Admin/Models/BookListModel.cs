using Autofac;
using Exam1_2.Areas.Admin.Models;
using Exam1_2.Infrastructure.Services;
using Exam1_2.Library.Models;

namespace Exam1_2.Library.Areas.Admin.Models
{
	public class BookListModel : BaseModel
	{
        private IBookService? _bookService;

        public BookListModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public override void ResolveDependency(ILifetimeScope scope)
        {
            base.ResolveDependency(scope);
            _bookService = _scope.Resolve<IBookService>();
        }

        internal object? GetPagedBooks(DataTablesAjaxRequestModel model)
		{
            
            var data = _bookService.GetCourses(
                model.PageIndex,
                model.PageSize,
                model.SearchText,
                model.GetSortText(new string[] { "Title", "Available", "PublicationDate" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.Availble.ToString(),
                                record.PublicationDate.ToString(),
                                record.Id.ToString()
                        }
                    ).ToArray()
            };
        }
	}
}
