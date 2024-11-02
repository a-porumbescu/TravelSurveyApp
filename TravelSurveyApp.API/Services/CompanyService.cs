using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelSurveyApp.API.Interfaces;
using TravelSurveyApp.Data.Data;
using TravelSurveyApp.Data.Models;

namespace TravelSurveyApp.API.Services;

public class CompanyService : ICompanyService
{
    private readonly ApplicationDbContext _context;

    public CompanyService(ApplicationDbContext context)
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
        var existingCompany = await _context.Companies.FirstOrDefaultAsync(c => c.Id == company.Id);

        if (existingCompany == null)
        {
            return null;
        }
        
        existingCompany.Name = company.Name;
        existingCompany.Description = company.Description;
        existingCompany.Logo = company.Logo;
        existingCompany.IsDeleted = company.IsDeleted;
        existingCompany.DateOfFoundation = company.DateOfFoundation;
        existingCompany.PricePolicy = company.PricePolicy;
        
        await _context.SaveChangesAsync();
        
        return existingCompany;
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