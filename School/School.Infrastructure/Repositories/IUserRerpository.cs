using School.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
    public interface IUserRerpository : IRepository<ApplicationUser, Guid>
    {
        Task<ApplicationUser> GetUserAsync(string email, string password);
    }
}
