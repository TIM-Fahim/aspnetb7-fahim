using Autofac;
using Microsoft.AspNetCore.Mvc;
using School.Api.DTOs;

namespace School.Api.Controllers
{
    [ApiController]

    [Route("v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILifetimeScope _scope;
        private readonly ILogger<UserController> _logger;
        public UserController(ILifetimeScope scope, ILogger<UserController> logger)
        {
            _scope = scope;
            _logger = logger;
        }
        [HttpPost]
        public async Task<ActionResult<object>> Get(UserDTO userDTO)
        {
            userDTO.ResolveDependency(_scope);
            var token = await userDTO.GetToken();
            return Ok(token);
        }

    }
}
