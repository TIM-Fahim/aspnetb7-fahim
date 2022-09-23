using Autofac;

namespace Library
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<CourseModel>().As<ICourseModel>()
            //    .InstancePerLifetimeScope();

            //builder.RegisterType<CourseModel>().AsSelf();
            //builder.RegisterType<CourseCreateModel>().AsSelf();
            //builder.RegisterType<CourseListModel>().AsSelf();

            base.Load(builder);
        }
    }
}
