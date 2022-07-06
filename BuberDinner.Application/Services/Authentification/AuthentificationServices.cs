using BuberDinner.Application.Common.Interfaces.Authentification;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Common.Errors;
using BuberDinner.Domain.Entities;
using ErrorOr;

namespace BuberDinner.Application.Services.Authentification;

public class AuthentificationServices : IAuthentificationServices
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthentificationServices(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public ErrorOr<AuthentificationResult> Register(string firstName, string lastName, string email, string password)
    {
        
        //1.Validate the user exists
        if(_userRepository.getUserByEmail(email) is not null)
        {
            return Errors.User.DuplicateEmail;
        }
        //2.Create user (generate unique id)
        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };
        
        _userRepository.Add(user);
        
        //3.Create the token
        var token = _jwtTokenGenerator.GenerateToken(user);
        
        return new AuthentificationResult(user,token);
    }

    public ErrorOr<AuthentificationResult> Login(string email, string password)
    {
        //1. Validate the user exists
        if(_userRepository.getUserByEmail(email) is not User user)
        {
            return Errors.Authentification.InvalidCreadentials;
        }
        //2. Validate the password is correct
        if (user.Password != password)
        {
            return Errors.Authentification.InvalidCreadentials;
        }
        //3.Create the token
        var token = _jwtTokenGenerator.GenerateToken(user);
        
        return new AuthentificationResult(user,token);
    }
}