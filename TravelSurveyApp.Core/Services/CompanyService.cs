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
        var companies = await _companyRepository.GetAllAsync();

        return companies.Select(c => c.ToCompanyDTO()).ToList();
    }

    public async Task<CompanyDTO?> GetByIdAsync(int id)
    {
        var company = await _companyRepository.GetByIdAsync(id);

        return company.ToCompanyDTO();
    }

    public async Task<CompanyDTO?> CreateCompanyAsync(CreateCompanyDTO companyDTO)
    {
        var company = await _companyRepository.AddAsync(companyDTO.ToCompanyFromCompanyDTO());
        
        return company.ToCompanyDTO();
    }

    public async Task<CompanyDTO?> UpdateCompanyAsync(int id, UpdateCompanyDTO companyDTO)
    {
        var company = await _companyRepository.GetByIdAsync(id);

        if (company is null)
        {
            return null;
        }

        var updatedCompany = await _companyRepository.UpdateAsync(companyDTO.ToCompanyFromCompanyDTO());
        
        return updatedCompany?.ToCompanyDTO();
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var company = await _companyRepository.GetByIdAsync(id);

        if (company is null)
        {
            return false;
        }

        return await _companyRepository.DeleteAsync(id);
    }
}