using EmployeeMgmtDemo.Models;
using EmployeeMgmtDemo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMgmtDemo.Controllers;

[Authorize(Roles = "Admin")]
public class DepartmentsController : Controller
{
    private readonly IDepartmentService _departments;

    public DepartmentsController(IDepartmentService departments) => _departments = departments;

    public IActionResult Index() => View(_departments.GetAll());

    public IActionResult Create() => View(new Department());

    [HttpPost]
    public IActionResult Create(Department dept)
    {
        if (!ModelState.IsValid) return View(dept);
        _departments.Add(dept);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var dept = _departments.GetById(id);
        if (dept == null) return NotFound();
        return View(dept);
    }

    [HttpPost]
    public IActionResult Edit(Department dept)
    {
        if (!_departments.Exists(dept.DepartmentId)) return NotFound();
        if (!ModelState.IsValid) return View(dept);

        _departments.Update(dept);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var dept = _departments.GetById(id);
        if (dept == null) return NotFound();
        return View(dept);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _departments.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}