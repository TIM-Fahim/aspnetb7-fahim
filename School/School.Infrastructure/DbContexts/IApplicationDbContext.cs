using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Entities;

namespace School.Infrastructure.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<ApplicationUser> Users { get; set; }
    }
}