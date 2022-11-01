using BuberDinner.Domain.User;

namespace BuberDinner.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? getUserByEmail(string email);
    void Add(User user);
}