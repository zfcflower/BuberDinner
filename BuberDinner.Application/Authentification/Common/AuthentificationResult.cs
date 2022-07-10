using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Authentification.Common;

public record AuthentificationResult(User user,string Token);