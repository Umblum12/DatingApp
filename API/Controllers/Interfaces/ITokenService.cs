using API.Entities;

namespace API.Controllers.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}