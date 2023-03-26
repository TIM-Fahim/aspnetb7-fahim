using Autofac;
using Microsoft.AspNetCore.Cors.Infrastructure;
using NuGet.Protocol.Core.Types;
using School.Infrastructure.DbContexts;
using School.Infrastructure.Repositories;
using School.Infrastructure.Services;
using School.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure
{
    public class InfrastructureModule : Module
    {

        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public InfrastructureModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            //Creatring instanse of ApplicationDbContext during dependency injection
            builder.RegisterType<ApplicationDbContext>().AsSelf()
               .WithParameter("connectionString", _connectionString)
               .WithParameter("migrationAssemblyName", _migrationAssemblyName)
               .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
            .InstancePerLifetimeScope();
            
            builder.RegisterType<StudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserRepository>().As<IUserRerpository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ApplicationUserService>().As<IApplicationUserService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<TokenService>().As<ITokenService>()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
