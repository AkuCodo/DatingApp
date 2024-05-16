using DatingApp.Domain.Entities;

namespace DatingApp.Domain.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
