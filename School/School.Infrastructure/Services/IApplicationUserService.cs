using ApplicationUserBO = School.Infrastructure.BusinessObjects.ApplicationUser;
using ApplicationUserEO = School.Infrastructure.Entities.ApplicationUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Services
{
    public interface IApplicationUserService
    {
        Task<string> Login(ApplicationUserBO applicationUserBO);
        Task<string> Register(ApplicationUserBO applicationUserBO);
    }
}
