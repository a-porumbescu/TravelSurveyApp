using TravelSurveyApp.Data.Enums;

namespace TravelSurveyApp.Shared.DTOs.Company;

public class CompanyDTO
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Logo { get; set; }
    public string Link { get; set; }
    public string Keywords { get; set; }
    public DateTime DateOfFoundation { get; set; }
    public string PricePolicy { get; set; }
}