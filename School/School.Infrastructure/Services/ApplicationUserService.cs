﻿using AutoMapper;
using School.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ApplicationUserBO = School.Infrastructure.BusinessObjects.ApplicationUser;
using ApplicationUserEO = School.Infrastructure.Entities.ApplicationUser;

namespace School.Infrastructure.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        public ApplicationUserService(IMapper mapper, IApplicationUnitOfWork applicationUnitOfWork, ITokenService tokenService)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
            _mapper = mapper;
            _tokenService = tokenService;
        }

        public async Task<string> Login(ApplicationUserBO applicationUserBO)
        {
            var user = await _applicationUnitOfWork.Users.GetUserAsync(applicationUserBO.Email, applicationUserBO.Password);
            var claims = new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.ID.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                };
            var token = await _tokenService.GetJwtToken(claims);

            return token;
        }

        public Task<string> Register(ApplicationUserBO applicationUserBO)
        {
            throw new NotImplementedException();
        }
    }
}