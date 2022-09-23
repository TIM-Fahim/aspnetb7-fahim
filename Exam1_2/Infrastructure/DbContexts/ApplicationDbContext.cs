using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Exam1_2.Infrastructure.DbContexts;

namespace Exam1_2.Infrastructure.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}