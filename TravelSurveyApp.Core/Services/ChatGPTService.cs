using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OpenAI.Chat;
using TravelSurveyApp.Core.Interfaces;

namespace TravelSurveyApp.Core.Services;

public class ChatGPTService : IChatGPTService
{
    private readonly ChatClient _chatGPT;
    private readonly IConfiguration _configuration;
    private readonly ICompanyService _companyService;
    private readonly string _apiKey; 
    private readonly string ModelInstruction;

    public ChatGPTService(IConfiguration configuration, ICompanyService companyService)
    {
        _configuration = configuration;
        _companyService = companyService;
        _chatGPT = new ChatClient(model: "gpt-3.5-turbo-0125", apiKey: _configuration["ChatGPT:ApiKey"]);
        ModelInstruction = _configuration["ChatGPT:ModelInstruction"] ?? "Default instruction for the model.";
    }

    public async Task<string?> GetResponseAsync(string userResponse)
    {
        var companies = await _companyService.GetAllAsync();
        var companiesJson = JsonConvert.SerializeObject(companies);
        var fullModelInstruction = ModelInstruction + companiesJson;
        
        var messages = new List<ChatMessage>
        {
           ChatMessage.CreateSystemMessage(fullModelInstruction),
           ChatMessage.CreateUserMessage(userResponse),
        };

        var chatCompletion = await _chatGPT.CompleteChatAsync(messages);

        return chatCompletion.Value.Content[0].Text;
    }
}