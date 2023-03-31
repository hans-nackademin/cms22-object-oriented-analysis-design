using MVVM_WebApp.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace MVVM_WebApp.ViewModels;

public class RegisterViewModel
{
    [Display(Name = "Förnamn")]
    [Required(ErrorMessage = "Du måste ange ett förnamn")]
    [RegularExpression(@"^[a-öA-Ö]+(?:[é'-][a-öA-Ö]+)*$", ErrorMessage = "Du måste ange ett giltigt förnamn")]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Efternamn")]
    [Required(ErrorMessage = "Du måste ange ett efternamn")]
    [RegularExpression(@"^[a-öA-Ö]+(?:[é'-][a-öA-Ö]+)*$", ErrorMessage = "Du måste ange ett giltigt förnamn")]
    public string LastName { get; set; } = null!;


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


    [Display(Name = "Bekräfta Lösenord")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Du måste bekräfta lösenordet")]
    [Compare(nameof(Password), ErrorMessage = "Lösenorden matchar inte")]
    public string ConfirmPassword { get; set; } = null!;

    public string Button => "REGISTRERA";


    public static implicit operator UserEntity(RegisterViewModel viewModel)
    {
        var userEntity = new UserEntity
        {
            FirstName = viewModel.FirstName,
            LastName = viewModel.LastName,
            Email = viewModel.Email
        };
        userEntity.GenerateSecurePassword(viewModel.Password);

        return userEntity;
    }

}
