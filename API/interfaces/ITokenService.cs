using API.Entities;

namespace DatingApp.API.interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}