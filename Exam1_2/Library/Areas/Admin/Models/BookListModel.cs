using Autofac;
using Exam1_2.Areas.Admin.Models;
using Exam1_2.Infrastructure.Services;
using Library.Models;

namespace FirstDemo.Web.Areas.Admin.Models
{
	public class BookListModel : BaseModel
	{
        private IBookService? _bookService;

        public BookListModel(IBookService coursService)
        {
            _bookService = coursService;
        }

        public override void ResolveDependency(ILifetimeScope scope)
        {
            base.ResolveDependency(scope);
            _bookService = _scope.Resolve<IBookService>();
        }

        internal object? GetPagedCourses(DataTablesAjaxRequestModel model)
		{
            
            var data = _bookService.GetCourses(
                model.PageIndex,
                model.PageSize,
                model.SearchText,
                model.GetSortText(new string[] { "Title", "Fees", "ClassStartDate" }));

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
