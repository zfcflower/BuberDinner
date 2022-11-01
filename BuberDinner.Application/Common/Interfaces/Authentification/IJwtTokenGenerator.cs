using BuberDinner.Domain.User;

namespace BuberDinner.Application.Common.Interfaces.Authentification;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}