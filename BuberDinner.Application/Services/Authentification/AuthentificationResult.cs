using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authentification;

public record AuthentificationResult(User user,string Token);
