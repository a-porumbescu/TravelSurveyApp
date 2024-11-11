using TravelSurveyApp.Data.Enums;
using TravelSurveyApp.Data.Models;
using TravelSurveyApp.Shared.DTOs.Company;

namespace TravelSurveyApp.Core.Mappers;

public static class CompanyMappers
{
    public static CompanyDTO ToCompanyDTO(this Company company)
    {
        return new CompanyDTO()
        {
            Id = company.Id,
            Name = company.Name,
            Description = company.Description,
            Link = company.Link,
            Keywords = company.Keywords, 
            Logo = company.Logo,
            DateOfFoundation = company.DateOfFoundation,
            PricePolicy = nameof(company.PricePolicy)
        };
    }

    public static Company ToCompanyFromCompanyDTO(this CompanyDTO companyDTO)
    {
        Enum.TryParse(companyDTO.PricePolicy, true, out PricePolicy result);
        return new Company
        {
            Id = companyDTO.Id,
            Name = companyDTO.Name,
            Description = companyDTO.Description,
            Logo = companyDTO.Logo,
            Link = companyDTO.Link,
            Keywords = companyDTO.Keywords,
            DateOfFoundation = companyDTO.DateOfFoundation,
            PricePolicy = result
        };
    }
    
    public static Company ToCompanyFromCompanyDTO(this CreateCompanyDTO companyDTO)
    {
        return new Company
        {
            Name = companyDTO.Name,
            Description = companyDTO.Description,
            Logo = companyDTO.Logo,
            Link = companyDTO.Link,
            Keywords = companyDTO.Keywords,
            DateOfFoundation = companyDTO.DateOfFoundation,
            PricePolicy = companyDTO.PricePolicy
        };
    }
    
    public static Company ToCompanyFromCompanyDTO(this UpdateCompanyDTO companyDTO)
    {
        return new Company
        {
            Name = companyDTO.Name,
            Description = companyDTO.Description,
            Logo = companyDTO.Logo,
            Link = companyDTO.Link,
            Keywords = companyDTO.Keywords,
            DateOfFoundation = companyDTO.DateOfFoundation,
            PricePolicy = companyDTO.PricePolicy
        };
    }
}