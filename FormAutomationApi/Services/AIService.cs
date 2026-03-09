using FormAutomationApi.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Options;

namespace FormAutomationApi.Services
{
    public class AIService
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public AIService(IOptions<OpenAISettings> settings)
        {
            _apiKey = settings.Value.ApiKey;
            _httpClient = new HttpClient();
        }

        public async Task<string> AnaylseForm(string base64File) {
            //            var request = new
            //            {
            //                model = "gpt-4o-mini",
            //                messages = new[]
            //           {
            //                new
            //                {
            //                    role = "system",
            //                    content = "You are a medical form parser."
            //                },
            //                new
            //                {
            //                    role = "user",
            //                    content = $@"
            //Analyze this hospital form image or document.

            //Extract all form fields and convert them into this template format:

            //Example:
            //First Name {{first_name:text:req}}
            //DOB {{dob:date:req}}

            //Rules:
            //- field types: text, date, number, tel, checkbox
            //- req = required
            //- opt = optional

            //FileBase64:
            // url = $""data:image/png;base64,{{base64Image}}""
            //"
            //                }
            //            }
            //            };

            var request = new
            {
                model = "gpt-4o",
                response_format = new { type = "json_object" },
                messages = new object[]
     {
        new
        {
            role = "user",
            content = new object[]
            {
                new
                {
                    type = "text",
                    text =
@"Analyze this hospital form image.

1. Detect all form fields.
2. Generate a template format.
3. Also return a structured list of fields.

Template format example:
First Name {{first_name:text:req}}
DOB {{dob:date:req}}

Rules:
field types: text, date, number, tel, checkbox
req = required
opt = optional

Return JSON in this format:

{
  ""template"": ""string"",
  ""fields"": [
    {
      ""label"": ""First Name"",
      ""name"": ""first_name"",
      ""type"": ""text"",
      ""required"": true
    }
  ]
}"
                },
                new
                {
                    type = "image_url",
                    image_url = new
                    {
                        url = $"data:image/png;base64,{base64File}"
                    }
                }
            }
        }
     }
            };

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

            var response = await _httpClient.PostAsJsonAsync(
                "https://api.openai.com/v1/chat/completions",
                request
            );

            var result = await response.Content.ReadFromJsonAsync<dynamic>();

            Console.WriteLine(result );
            return "console";
        }


    }
}


public class OpenAIResponse
{
    public List<Choice> Choices { get; set; }
}

public class Choice
{
    public Message Message { get; set; }
}

public class Message
{
    public string Content { get; set; }
}