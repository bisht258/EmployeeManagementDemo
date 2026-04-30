using System.ComponentModel.DataAnnotations;

namespace EmployeeMgmtDemo.Models;

public class Department
{
    public int DepartmentId { get; set; }

    [Required]
    [StringLength(50)]
    public string DepartmentName { get; set; } = "";
}