using TravelSurveyApp.Core.Interfaces;
using TravelSurveyApp.Core.Mappers;
using TravelSurveyApp.Data.Interfaces;
using TravelSurveyApp.Data.Models;
using TravelSurveyApp.Shared.DTOs.Company;

namespace TravelSurveyApp.Core.Services;

public class CompanyService : ICompanyService
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyService(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }
    
    public async Task<List<CompanyDTO>> GetAllAsync()
    {
        List<Company> companies = await _companyRepository.GetAllAsync();
        var result = companies.Select(company  => company.ToCompanyDTO()).ToList();
        
        return result;
    }
    
    public async Task<CompanyDTO?> GetByIdAsync(int id)
    {
        var companies = await _companyRepository.GetByIdAsync(id);

        return companies?.ToCompanyDTO();
    }

    public async Task<CompanyDTO?> CreateCompanyAsync(CreateCompanyDTO companyDTO)
    {
        var addedCompany = await _companyRepository.AddAsync(companyDTO.ToCompanyFromCompanyDTO());
        
        return addedCompany?.ToCompanyDTO();
    }

    public async Task<CompanyDTO?> UpdateCompanyAsync(int id, UpdateCompanyDTO companyDTO)
    {
        var existingCompany = await _companyRepository.GetByIdAsync(id);

        if (existingCompany == null)
        {
            return null;
        }
        
        existingCompany.Name = companyDTO.Name;
        existingCompany.Description = companyDTO.Description;
        existingCompany.Logo = companyDTO.Logo;
        existingCompany.IsDeleted = companyDTO.IsDeleted;
        existingCompany.DateOfFoundation = companyDTO.DateOfFoundation;
        existingCompany.PricePolicy = companyDTO.PricePolicy;
        
        await _companyRepository.UpdateAsync(existingCompany);
        
        return existingCompany.ToCompanyDTO();
    }

    public async Task<CompanyDTO?> DeleteAsync(int id)
    {
        var company = await _companyRepository.DeleteAsync(id);

        if (company == null)
        {
            return null;
        }

        company.IsDeleted = true;

        return company.ToCompanyDTO();
    }
}