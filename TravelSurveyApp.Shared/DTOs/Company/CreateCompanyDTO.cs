using System.ComponentModel.DataAnnotations;
using TravelSurveyApp.Data.Enums;

namespace TravelSurveyApp.Shared.DTOs.Company;

public class CreateCompanyDTO
{
    [Required]
    [MaxLength(15, ErrorMessage = "Name cannot be longer than 15 characters.")]
    public string Name {get; set;}
    [Required]
    [MaxLength(50, ErrorMessage = "Description cannot be longer than 50 characters.")]
    public string Description {get; set;}
    public string Logo {get; set;}
    public string Link { get; set; }
    public string Keywords { get; set; }
    [Required] 
    public DateTime DateOfFoundation { get; set; }
    [Required]
    public PricePolicy PricePolicy {get; set;}
}