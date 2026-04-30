using EmployeeMgmtDemo.Models;

namespace EmployeeMgmtDemo.Repositories;

public class InMemoryUserRepository : IUserRepository
{
    private static readonly List<AppUser> _users = new()
    {
        new AppUser { UserId = "admin", Password = "Admin@123", Role = "Admin" },
        new AppUser { UserId = "user",  Password = "User@123",  Role = "User" }
    };

    public AppUser? Validate(string userId, string password)
    {
        return _users.FirstOrDefault(u =>
            u.UserId.Equals(userId, StringComparison.OrdinalIgnoreCase) &&
            u.Password == password);
    }
}