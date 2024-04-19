using System.ComponentModel.DataAnnotations;

namespace Silicon_WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public AccountBasicInfo? Basic { get; set; }

    public AccountBasicInfo? Address { get; set; }
}


public class AccountBasicInfo
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

    [Display(Name = "Phone", Prompt = "Enter your phone")]
    public string PhoneNumber { get; set; } = null!;

    [Display(Name = "Bio", Prompt = "Add a short")]
    public string? Bio { get; set; }
}

public class AccountAddressInfo
{

    [Required]
    [Display(Name = "AddressLine 1", Prompt = "Enter your Address line")]
    public string AddressLine_1 { get; set; } = null!;

    [Display(Name = "AddressLine 2", Prompt = "Enter your secoundary Address line")]

    public string? AddressLine_2 { get; set;}

    [Required]
    [Display(Name = "PostalCode", Prompt = "Enter your postal code")]
    public string PostalCode { get; set; } = null!;

    [Required]
    [Display(Name = "City", Prompt = "Enter your city")]
    public string City { get; set; } = null!;
}