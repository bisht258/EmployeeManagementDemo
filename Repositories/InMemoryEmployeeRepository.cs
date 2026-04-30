using EmployeeMgmtDemo.Models;

namespace EmployeeMgmtDemo.Repositories;

public class InMemoryEmployeeRepository : IEmployeeRepository
{
    private static readonly object _lock = new();
    private static readonly List<Employee> _employees = new()
    {
        new Employee { EmployeeId = 1, FirstName = "Vishal", LastName = "Bisht", DepartmentId = 2 },
        new Employee { EmployeeId = 2, FirstName = "Dhhairya", LastName = "Shukla", DepartmentId = 1 },
        new Employee { EmployeeId = 3, FirstName = "Piyush", LastName = "Vijay", DepartmentId = 1 }
    };

    public List<Employee> GetAll()
    {
        lock (_lock)
        {
            return _employees.Select(e => new Employee
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                DepartmentId = e.DepartmentId
            }).ToList();
        }
    }

    public Employee? GetById(int id)
    {
        lock (_lock)
        {
            var e = _employees.FirstOrDefault(x => x.EmployeeId == id);
            return e == null ? null : new Employee
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                DepartmentId = e.DepartmentId
            };
        }
    }

    public void Add(Employee emp)
    {
        lock (_lock)
        {
            var nextId = _employees.Count == 0 ? 1 : _employees.Max(x => x.EmployeeId) + 1;
            emp.EmployeeId = nextId;
            _employees.Add(new Employee
            {
                EmployeeId = emp.EmployeeId,
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                DepartmentId = emp.DepartmentId
            });
        }
    }

    public void Update(Employee emp)
    {
        lock (_lock)
        {
            var existing = _employees.FirstOrDefault(x => x.EmployeeId == emp.EmployeeId);
            if (existing == null) return;
            existing.FirstName = emp.FirstName;
            existing.LastName = emp.LastName;
            existing.DepartmentId = emp.DepartmentId;
        }
    }

    public void Delete(int id)
    {
        lock (_lock)
        {
            var existing = _employees.FirstOrDefault(x => x.EmployeeId == id);
            if (existing == null) return;
            _employees.Remove(existing);
        }
    }

    public bool Exists(int id)
    {
        lock (_lock) return _employees.Any(x => x.EmployeeId == id);
    }
}