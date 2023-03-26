using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Entities;
using School.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
    public class UserRepository : Repository<ApplicationUser, Guid>, IUserRerpository
    {
        private readonly IApplicationDbContext _context;
        public UserRepository(IApplicationDbContext context) : base((DbContext)context)
        {
            _context = context;
        }

        //public async Task<ApplicationUser> CreateUserAsync(string email, string password)
        //{
        //    var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        //    return user;
        //}
        public async Task<ApplicationUser> GetUserAsync(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
            return user;
        }
    }
}
