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

    [HttpGet]
    [Route("api/companies")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var companies = await _companyService.GetAllAsync();
            return Ok(companies);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    [Route("api/companies/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var company = await _companyService.GetByIdAsync(id);
            return Ok(company);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpPost]
    [Route("api/companies")]
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

    [HttpPut]
    [Route("api/companies/{id:int}")]
    public async Task<IActionResult> Update(int id, UpdateCompanyDTO updateCompanyDTO)
    {
        try
        {
            var company = await _companyService.UpdateCompanyAsync(id, updateCompanyDTO);
            return Ok(company);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete]
    [Route("api/companies/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var company = await _companyService.DeleteAsync(id);
            return Ok(company);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}