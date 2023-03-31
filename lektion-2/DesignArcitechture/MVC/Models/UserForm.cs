using System.ComponentModel.DataAnnotations;

namespace MVC.Models;

public class UserForm
{

    [Display(Name = "Förnamn")]
    [Required(ErrorMessage = "Du måste ange ett förnamn")]
    public string FirstName { get; set; } = null!;



    [Display(Name = "Efternamn")]
    [Required(ErrorMessage = "Du måste ange ett efternamn")]
    public string LastName { get; set;} = null!;
}
