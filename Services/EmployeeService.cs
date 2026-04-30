using EmployeeMgmtDemo.Models;
using EmployeeMgmtDemo.Repositories;

namespace EmployeeMgmtDemo.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repo;
    public EmployeeService(IEmployeeRepository repo) => _repo = repo;

    public List<Employee> GetAll() => _repo.GetAll();
    public Employee? GetById(int id) => _repo.GetById(id);
    public void Add(Employee emp) => _repo.Add(emp);
    public void Update(Employee emp) => _repo.Update(emp);
    public void Delete(int id) => _repo.Delete(id);
    public bool Exists(int id) => _repo.Exists(id);
}