using Microsoft.EntityFrameworkCore;
using TravelSurveyApp.Data.Data;
using TravelSurveyApp.Data.Interfaces;
using TravelSurveyApp.Data.Models;

namespace TravelSurveyApp.Data.Repositories;

public class CompanyRepository : ICompanyRepository
{
    private readonly ApplicationDbContext _context;
    
    public CompanyRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Company>> GetAllAsync()
    {
        return await _context.Companies.Where(c => !c.IsDeleted).ToListAsync();
    }

    public async Task<Company?> GetByIdAsync(int id)
    {
        return await _context.Companies.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<Company> AddAsync(Company companyModel)
    {
        await _context.Companies.AddAsync(companyModel);
        await _context.SaveChangesAsync();

        return companyModel;
    }

    public async Task<Company?> UpdateAsync(Company company)
    {
        _context.Companies.Update(company);
        await _context.SaveChangesAsync();
        
        return company;
    }

    public async Task<Company?> DeleteAsync(int id)
    {
        
        var company = await _context.Companies.FirstOrDefaultAsync(c => c.Id == id);

        if (company == null)
        {
            return null;
        }

        company.IsDeleted = true;

        await _context.SaveChangesAsync();

        return company; 
    }
}