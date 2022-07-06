using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Infrasctructure.Persistence;

public class UserRepository : IUserRepository
{
    private static List<User> _users = new();
    public User? getUserByEmail(string email)
    {
        return _users.SingleOrDefault(x=>x.Email==email);
    }

    public void Add(User user)
    {
        _users.Add(user);
    }
}