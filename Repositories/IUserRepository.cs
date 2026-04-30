using EmployeeMgmtDemo.Models;

namespace EmployeeMgmtDemo.Repositories;

public interface IUserRepository
{
    AppUser? Validate(string userId, string password);
}