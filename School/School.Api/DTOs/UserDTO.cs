using Autofac;
using AutoMapper;
using School.Infrastructure.BusinessObjects;
using School.Infrastructure.Services;

namespace School.Api.DTOs
{
    public class UserDTO
    {
        private IApplicationUserService? _applicaitonUserService;
        private IMapper _mapper;
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public UserDTO() { }
        public UserDTO(IApplicationUserService? applicaitonUserService, IMapper mapper)
        {
            _applicaitonUserService = applicaitonUserService;
            _mapper = mapper;
        }
        public void ResolveDependency(ILifetimeScope scope)
        {
            _applicaitonUserService = scope.Resolve<IApplicationUserService>();
            _mapper = scope.Resolve<IMapper>();
        }

        public async Task<string> GetToken()
        {
            //var user = _mapper.Map<Infrastructure.BusinessObjects.ApplicationUser>(this);
            var user = new ApplicationUser
            {
                Email = this.Email,
                Password = this.Password
            };
            var token = await _applicaitonUserService?.Login(user);
            return token;
        }

        public async Task<string> Register()
        {
            var user = _mapper.Map<Infrastructure.BusinessObjects.ApplicationUser>(this);
            var token = await _applicaitonUserService?.Register(user);
            return token;
        }
    }
}
