using TravelSurveyApp.Shared.DTOs.Company;

namespace TravelSurveyApp.Core.Interfaces;

public interface ICompanyService
{
    Task<List<CompanyDTO>> GetAllAsync();
    Task<CompanyDTO?> GetByIdAsync(int id);
    Task<CompanyDTO?> CreateCompanyAsync(CreateCompanyDTO companyDTO);
    Task<CompanyDTO?> UpdateCompanyAsync(int id, UpdateCompanyDTO companyDTO);
    Task<bool> DeleteAsync(int id);
}