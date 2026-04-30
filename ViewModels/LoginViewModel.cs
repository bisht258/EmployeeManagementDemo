using System.ComponentModel.DataAnnotations;

namespace EmployeeMgmtDemo.ViewModels;

public class LoginViewModel
{
    [Required]
    public string UserId { get; set; } = "";

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = "";

    public string? ReturnUrl { get; set; }
}