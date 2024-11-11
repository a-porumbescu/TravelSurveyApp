namespace TravelSurveyApp.Core.Interfaces;

public interface IChatGPTService
{
    Task<string?> GetResponseAsync(string userResponse);
}