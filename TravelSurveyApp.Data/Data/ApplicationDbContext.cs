using TravelSurveyApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelSurveyApp.Data.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }
    
    public DbSet<CompanyModel> Companies { get; set; }
}