using System.ComponentModel.DataAnnotations.Schema;
using TravelSurveyApp.Data.Enums;

namespace TravelSurveyApp.Data.Models;

[Table("Companies")]
public class CompanyModel
{
    public long Id {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public string Logo {get; set;}
    public bool IsDeleted {get; set;} = false;
    public DateTime DateOfFoundation {get; set;}
    public PricePolicy PricePolicy {get; set;}
}