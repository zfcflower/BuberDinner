using BuberDinner.Domain.User;

namespace BuberDinner.Application.Authentification.Common;

public record AuthentificationResult(User User,string Token);