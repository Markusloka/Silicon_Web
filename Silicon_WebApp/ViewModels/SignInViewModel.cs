﻿using System.ComponentModel.DataAnnotations;
namespace Silicon_WebApp.ViewModels;

public class SignInViewModel
{
    [Required]
    [Display(Name = "E-mail address", Prompt ="Enter your e-mail address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "RemeberMe", Prompt = "Remember me")]

    public bool IsPresistent {  get; set; }
}
