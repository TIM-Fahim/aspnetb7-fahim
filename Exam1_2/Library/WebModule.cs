using Autofac;
using Exam1_2.Areas.Admin.Models;
using FirstDemo.Web.Areas.Admin.Models;

namespace Exam1_2.Library
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookModel>().As<IBookModel>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BookModel>().AsSelf();
            builder.RegisterType<BookCreateModel>().AsSelf();
            builder.RegisterType<BookListModel>().AsSelf();

            base.Load(builder);
        }
    }
}
