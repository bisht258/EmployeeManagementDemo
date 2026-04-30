using EmployeeMgmtDemo.Models;

namespace EmployeeMgmtDemo.Services;

public interface IDepartmentService
{
    List<Department> GetAll();
    Department? GetById(int id);
    void Add(Department dept);
    void Update(Department dept);
    void Delete(int id);
    bool Exists(int id);
}