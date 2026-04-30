using EmployeeMgmtDemo.Models;

namespace EmployeeMgmtDemo.Repositories;

public class InMemoryDepartmentRepository : IDepartmentRepository
{
    private static readonly object _lock = new();
    private static readonly List<Department> _departments = new()
    {
        new Department { DepartmentId = 1, DepartmentName = "HR" },
        new Department { DepartmentId = 2, DepartmentName = "IT" },
        new Department { DepartmentId = 3, DepartmentName = "Finance" }
    };

    public List<Department> GetAll()
    {
        lock (_lock) return _departments.Select(d => new Department { DepartmentId = d.DepartmentId, DepartmentName = d.DepartmentName }).ToList();
    }

    public Department? GetById(int id)
    {
        lock (_lock)
        {
            var d = _departments.FirstOrDefault(x => x.DepartmentId == id);
            return d == null ? null : new Department { DepartmentId = d.DepartmentId, DepartmentName = d.DepartmentName };
        }
    }

    public void Add(Department dept)
    {
        lock (_lock)
        {
            var nextId = _departments.Count == 0 ? 1 : _departments.Max(x => x.DepartmentId) + 1;
            dept.DepartmentId = nextId;
            _departments.Add(new Department { DepartmentId = dept.DepartmentId, DepartmentName = dept.DepartmentName });
        }
    }

    public void Update(Department dept)
    {
        lock (_lock)
        {
            var existing = _departments.FirstOrDefault(x => x.DepartmentId == dept.DepartmentId);
            if (existing == null) return;
            existing.DepartmentName = dept.DepartmentName;
        }
    }

    public void Delete(int id)
    {
        lock (_lock)
        {
            var existing = _departments.FirstOrDefault(x => x.DepartmentId == id);
            if (existing == null) return;
            _departments.Remove(existing);
        }
    }

    public bool Exists(int id)
    {
        lock (_lock) return _departments.Any(x => x.DepartmentId == id);
    }
}