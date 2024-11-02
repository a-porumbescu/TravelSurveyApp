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
            Logo = company.Logo,
            DateOfFoundation = company.DateOfFoundation,
            PricePolicy = company.PricePolicy
        };
    }

    public static Company ToCompanyFromCompanyDTO(this CompanyDTO companyDTO)
    {
        return new Company
        {
            Id = companyDTO.Id,
            Name = companyDTO.Name,
            Description = companyDTO.Description,
            Logo = companyDTO.Logo,
            DateOfFoundation = companyDTO.DateOfFoundation,
            PricePolicy = companyDTO.PricePolicy
        };
    }
    
    public static Company ToCompanyFromCompanyDTO(this CreateCompanyDTO companyDTO)
    {
        return new Company
        {
            Name = companyDTO.Name,
            Description = companyDTO.Description,
            Logo = companyDTO.Logo,
            DateOfFoundation = companyDTO.DateOfFoundation,
            PricePolicy = companyDTO.PricePolicy
        };
    }
}