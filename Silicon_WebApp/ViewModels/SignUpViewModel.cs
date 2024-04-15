using Silicon_WebApp.Filters;
using System.ComponentModel.DataAnnotations;

namespace Silicon_WebApp.ViewModels;

public class SignUpViewModel
{
    [Required]
    [Display(Name = "First name", Prompt = "Enter your firstname")]

    public string FirstName { get; set; } = null!;
    [Required]
    [Display(Name = "Last name", Prompt = "Enter your lastname")]

    public string LastName { get; set; } = null!;

    [Required]
    [Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage ="Passwords do not match")]
    public string ConfirmPassword { get; set; } = null!;

    [CheckboxRequried]
    [Display(Name = "I agree to the term & conditions", Prompt = "Terms and conditions")]
    public bool TermsAndConditions { get; set; } 
}
