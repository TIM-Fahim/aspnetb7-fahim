using Exam1_2.Infrastructure.Repositories;

namespace Exam1_2.Infrastructure.UnitOfWorks
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IBookRepository Books { get; }
    }
}