using BuberDinner.Application.Common.Interfaces.Services;

namespace BuberDinner.Infrasctructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.Now;
}