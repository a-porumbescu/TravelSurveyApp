using TravelSurveyApp.Data.Models;

namespace TravelSurveyApp.Data.Interfaces;

public interface ICompanyRepository
{
    Task<List<Company>> GetAllAsync();
    Task<Company?> GetByIdAsync(int id);
    Task<Company> AddAsync(Company company);
    Task<Company?> UpdateAsync(Company company);
    Task<Company?> DeleteAsync(int id);
}