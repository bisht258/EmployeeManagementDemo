using EmployeeMgmtDemo.Models;

namespace EmployeeMgmtDemo.Services;

public interface IAuthService
{
    AppUser? Validate(string userId, string password);
}