using System.ComponentModel.DataAnnotations;
using TravelSurveyApp.Data.Enums;

namespace TravelSurveyApp.Shared.DTOs.Company;

public class UpdateCompanyDTO
{
    [Required]
    [MaxLength(15, ErrorMessage = "Name cannot be longer than 15 characters.")]
    public string Name {get; set;}
    [Required]
    [MaxLength(50, ErrorMessage = "Description cannot be longer than 50 characters.")]
    public string Description { get; set; }
    [Required]
    public string Logo {get; set;}
    [Required]
    public bool IsDeleted {get; set;} = false;
    [Required] 
    public DateTime DateOfFoundation { get; set; }
    [Required]
    public PricePolicy PricePolicy {get; set;}
}