using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interfaces.Authentification;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}