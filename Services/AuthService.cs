using EmployeeMgmtDemo.Models;
using EmployeeMgmtDemo.Repositories;

namespace EmployeeMgmtDemo.Services;

public class AuthService : IAuthService
{
    private readonly IUserRepository _users;
    public AuthService(IUserRepository users) => _users = users;

    public AppUser? Validate(string userId, string password) => _users.Validate(userId, password);
}