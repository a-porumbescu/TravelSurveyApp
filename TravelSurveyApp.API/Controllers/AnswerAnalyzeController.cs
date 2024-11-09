using Microsoft.AspNetCore.Mvc;
using TravelSurveyApp.Core.Interfaces;
using TravelSurveyApp.Shared.DTOs.Company;

namespace TravelSurveyApp.API.Controllers;

[ApiController]
[Route("api/analyze")]
public class AnswerAnalyzeController : ControllerBase
{
    private readonly IChatGPTService _chatGpTService;

    public AnswerAnalyzeController(IChatGPTService chatGpTService)
    {
        _chatGpTService = chatGpTService;
    }

    [HttpPost("get_answer")]
    public async Task<IActionResult> GetAnswer([FromBody]string userResponse)
    {
        try
        {
            return Ok(await _chatGpTService.GetResponseAsync(userResponse));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}