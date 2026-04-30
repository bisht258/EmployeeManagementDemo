using EmployeeMgmtDemo.Models;
using EmployeeMgmtDemo.Repositories;

namespace EmployeeMgmtDemo.Services;

public class DepartmentService : IDepartmentService
{
    private readonly IDepartmentRepository _repo;
    public DepartmentService(IDepartmentRepository repo) => _repo = repo;

    public List<Department> GetAll() => _repo.GetAll();
    public Department? GetById(int id) => _repo.GetById(id);
    public void Add(Department dept) => _repo.Add(dept);
    public void Update(Department dept) => _repo.Update(dept);
    public void Delete(int id) => _repo.Delete(id);
    public bool Exists(int id) => _repo.Exists(id);
}