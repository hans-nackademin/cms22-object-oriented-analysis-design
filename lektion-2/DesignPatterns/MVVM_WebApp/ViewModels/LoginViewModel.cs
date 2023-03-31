using MVVM_WebApp.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace MVVM_WebApp.ViewModels;

public class LoginViewModel
{
    [Display(Name = "E-postadress")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Du måste ange en e-postadress")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Du måste ange en giltigt e-postadress")]
    public string Email { get; set; } = null!;


    [Display(Name = "Lösenord")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Du måste ange ett lösenord")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$", ErrorMessage = "Du måste ange ett giltigt lösenord")]
    public string Password { get; set; } = null!;


    public string Button => "LOGGA IN";

}
