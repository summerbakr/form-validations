using System.ComponentModel.DataAnnotations;
namespace FormValidations.Models

{
public class Survey
{   
    [Required]
    [MinLength(2, ErrorMessage="Sorry too short!")]
    public string Name{get; set;}

    [Required]
    public string Location{get; set;}

    

    [Required]
    public string Language{get; set;}
    
    [MaxLength(20)]
    public string Comment{get; set;}
    
}
}