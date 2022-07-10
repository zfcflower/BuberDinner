using BuberDinner.Application.Authentification.Commands.Register;
using BuberDinner.Application.Authentification.Common;
using BuberDinner.Application.Authentification.Queries.Login;
using BuberDinner.Contracts.Authentification;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[Route("auth")]
public class AuthentificationController : ApiController
{
    private readonly ISender _mediator;

    public AuthentificationController(ISender mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = new RegisterCommand(request.FirstName,
            request.LastName,
            request.Email,
            request.Password);
        var authResult = await _mediator.Send(command);

        return authResult.Match(
            result => Ok(MapAuthResult(result)),
            errors => Problem(errors));
    }

    

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = new LoginQuery(
            request.Email,
            request.Password);
        var authResult = await _mediator.Send(query);
        
        return authResult.Match(
            results => Ok(MapAuthResult(results)),
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