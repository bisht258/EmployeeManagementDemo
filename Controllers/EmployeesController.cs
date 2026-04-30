using EmployeeMgmtDemo.Models;
using EmployeeMgmtDemo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMgmtDemo.Controllers;

[Authorize]
public class EmployeesController : Controller
{
    private readonly IEmployeeService _employees;
    private readonly IDepartmentService _departments;

    public EmployeesController(IEmployeeService employees, IDepartmentService departments)
    {
        _employees = employees;
        _departments = departments;
    }

    [Authorize(Roles = "Admin,User")]
    public IActionResult Index()
    {
        ViewBag.Departments = _departments.GetAll();
        return View(_employees.GetAll());
    }

    [Authorize(Roles = "Admin,User")]
    public IActionResult Details(int id)
    {
        var emp = _employees.GetById(id);
        if (emp == null) return NotFound();
        ViewBag.Department = _departments.GetById(emp.DepartmentId);
        return View(emp);
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Create()
    {
        ViewBag.Departments = _departments.GetAll();
        return View(new Employee());
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public IActionResult Create(Employee emp)
    {
        if (!_departments.Exists(emp.DepartmentId))
            ModelState.AddModelError(nameof(emp.DepartmentId), "Select a valid department");

        if (!ModelState.IsValid)
        {
            ViewBag.Departments = _departments.GetAll();
            return View(emp);
        }

        _employees.Add(emp);
        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Edit(int id)
    {
        var emp = _employees.GetById(id);
        if (emp == null) return NotFound();
        ViewBag.Departments = _departments.GetAll();
        return View(emp);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public IActionResult Edit(Employee emp)
    {
        if (!_employees.Exists(emp.EmployeeId)) return NotFound();

        if (!_departments.Exists(emp.DepartmentId))
            ModelState.AddModelError(nameof(emp.DepartmentId), "Select a valid department");

        if (!ModelState.IsValid)
        {
            ViewBag.Departments = _departments.GetAll();
            return View(emp);
        }

        _employees.Update(emp);
        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Delete(int id)
    {
        var emp = _employees.GetById(id);
        if (emp == null) return NotFound();
        ViewBag.Department = _departments.GetById(emp.DepartmentId);
        return View(emp);
    }

    [HttpPost, ActionName("Delete")]
    [Authorize(Roles = "Admin")]
    public IActionResult DeleteConfirmed(int id)
    {
        _employees.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}