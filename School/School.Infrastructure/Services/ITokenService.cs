using System.Security.Claims;

namespace School.Infrastructure.Services
{
    public interface ITokenService
    {
        Task<string> GetJwtToken(IList<Claim> claims);
    }
}