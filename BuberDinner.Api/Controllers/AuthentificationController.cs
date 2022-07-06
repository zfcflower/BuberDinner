using BuberDinner.Application.Services.Authentification;
using BuberDinner.Contracts.Authentification;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[Route("auth")]
public class AuthentificationController : ApiController
{
    public readonly IAuthentificationServices _authentificationServices;

    public AuthentificationController(IAuthentificationServices authentificationServices)
    {
        _authentificationServices = authentificationServices;
    }
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authentificationServices.Register(request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        return authResult.Match(
            result => Ok(MapAuthResult(result)),
            errors => Problem(errors));
    }

    

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authentificationServices.Login(
            request.Email,
            request.Password);
        
        return authResult.Match(
            authResult => Ok(MapAuthResult(authResult)),
            errors => Problem(errors));
    }
    
    private static AuthentificationResponse MapAuthResult(AuthentificationResult authResult)
    {
        var response = new AuthentificationResponse(
            authResult.user.Id,
            authResult.user.FirstName,
            authResult.user.LastName,
            authResult.user.Email,
            authResult.Token);
        return response;
    }
}