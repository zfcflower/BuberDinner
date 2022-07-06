using ErrorOr;

namespace BuberDinner.Application.Services.Authentification;

public interface IAuthentificationServices
{
    ErrorOr<AuthentificationResult> Register(string firstName, string lastName, string email, string password);
    ErrorOr<AuthentificationResult> Login(string email, string password);
}