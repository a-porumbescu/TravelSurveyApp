using Microsoft.AspNetCore.Mvc;
using TravelSurveyApp.Core.Interfaces;
using TravelSurveyApp.Shared.DTOs.Company;

namespace TravelSurveyApp.API.Controllers;

[ApiController]
[Route("api/company")]
public class CompanyController : ControllerBase
{
    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCompanyDTO createCompanyDTO)
    {
        try
        {
            return Ok(await _companyService.CreateCompanyAsync(createCompanyDTO));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}