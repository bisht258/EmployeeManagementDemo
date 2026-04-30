using System.ComponentModel.DataAnnotations;

namespace EmployeeMgmtDemo.Models;

public class Employee
{
    public int EmployeeId { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = "";

    [Required]
    [StringLength(50)]
    public string LastName { get; set; } = "";

    [Required]
    public int DepartmentId { get; set; }
}