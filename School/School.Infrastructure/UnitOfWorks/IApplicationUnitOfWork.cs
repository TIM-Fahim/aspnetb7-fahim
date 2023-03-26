using School.Infrastructure.Repositories;

namespace School.Infrastructure.UnitOfWorks
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IStudentRepository Students { get; }
        IUserRerpository Users { get; }
    }
}