using BuberDinner.Api;
using BuberDinner.Application;
using BuberDinner.Infrasctructure;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services
        .AddPresentation()
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
    //builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>()); Fichiers cachés
    
}


var app = builder.Build();
{
    //app.UseMiddleware<ErrorHandlingMiddleware>(); Fichiers cachés
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
