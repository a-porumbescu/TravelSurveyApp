using TravelSurveyApp.Data.Models;

namespace TravelSurveyApp.API.Interfaces;

public interface ICompanyService
{
    Task<List<Company>> GetAllAsync();
    Task<Company?> GetByIdAsync(int id);
    Task<Company> AddAsync(Company company);
    Task<Company?> UpdateAsync(Company company);
    Task<Company?> DeleteAsync(int id);
}