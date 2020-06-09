using System.ComponentModel.DataAnnotations;
namespace FormValidations.Models

{
public class User
{   
    [Required]
    [MinLength(4, ErrorMessage="Sorry too short!")]
    public string FirstName{get; set;}

    [Required]
    [MinLength(4)]
    public string LastName{get; set;}

    [Required]
    [Range(0,120, ErrorMessage="Enter a valid age!")]
    public string Age{get; set;}

    [Required]
    [EmailAddress]
    public string Email{get; set;}
    
    [Required]
    [DataType(DataType.Password)]
    public string Password{get; set;}
    
}
}