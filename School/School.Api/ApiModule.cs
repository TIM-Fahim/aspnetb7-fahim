using Autofac;
using School.Api.DTOs;

namespace School.Api
{
    public class ApiModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentDTO>().AsSelf();
            builder.RegisterType<UserDTO>().AsSelf();
            //builder.RegisterType<CourseAdvancedModel>().AsSelf();

            base.Load(builder);
        }
    }
}
