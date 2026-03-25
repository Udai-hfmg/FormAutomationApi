using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

public class AiService
{
    private readonly IConfiguration _config;
    private readonly HttpClient _http;

    public AiService(IConfiguration config)
    {
        _config = config;
        _http = new HttpClient();
        _http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", _config["OpenAI:ApiKey"]);
    }

    public async Task<string> ExtractTemplate(byte[] fileBytes)
    {
        string base64 = Convert.ToBase64String(fileBytes);

        var requestBody = new
        {
            model = "gpt-4o-mini",
            messages = new[]
            {
                new {
                    role = "user",
                    content = new object[]
                    {
                        new { type="text", text="Reconstruct the document exactly.\r\n\r\nDetect form fields in two ways:\r\n\r\n1) Visual blanks such as:\r\n- ______\r\n- long underline blanks\r\n- empty boxes\r\n- empty space after labels\r\n\r\n2) Sentences asking the user to provide information.\r\n\r\nReplace the blank directly with a template variable.\r\n\r\nTemplate format:\r\n{{fieldName:type:req}}\r\n\r\nRules:\r\n- Replace the blank in the SAME LINE.\r\n- DO NOT add new lines.\r\n- DO NOT use arrows (→).\r\n- DO NOT show both the blank and the template.\r\n- The template MUST replace the blank.\r\n\r\nExample conversions:\r\n\r\nFirst Name: ______\r\n→ First Name: {{firstName:text:req}}\r\n\r\nPhone Number: ______\r\n→ Phone Number: {{phoneNumber:phone:req}}\r\n\r\nEmail: ______\r\n→ Email: {{email:email:req}}\r\n\r\nDate of Birth: ______\r\n→ Date of Birth: {{dateOfBirth:date:req}}\r\n\r\nAllowed types:\r\ntext\r\nemail\r\nphone\r\ndate\r\nnumber\r\ncheckbox\r\n\r\nRequired flag:\r\nreq = required\r\nopt = optional\r\n\r\nField naming rules:\r\nEmail → email\r\nPhone Number → phoneNumber\r\nFirst Name → firstName\r\nLast Name → lastName\r\nZip Code → zipCode\r\nDate of Birth → dateOfBirth\r\n\r\nIMPORTANT:\r\n- Preserve the original document text exactly.\r\n- Only replace blanks.\r\n- Do not add explanations.\r\n- Do not include arrows.\r\n- Do not repeat the template on a new line.\r\n\r\nReturn ONLY the reconstructed template."},
                        new { type="image_url", image_url = new { url = $"data:image/png;base64,{base64}" } }
                    }
                }
            }
        };

        var content = new StringContent(
            JsonConvert.SerializeObject(requestBody),
            Encoding.UTF8,
            "application/json"
        );

        var response = await _http.PostAsync(
            "https://api.openai.com/v1/chat/completions",
            content
        );

        var result = await response.Content.ReadAsStringAsync();

        var json = JsonDocument.Parse(result);

        var template = json
            .RootElement
            .GetProperty("choices")[0]
            .GetProperty("message")
            .GetProperty("content")
            .GetString();

        template = template
            .Replace("```plaintext", "")
            .Replace("```", "")
            .Trim();

        return template;
    }


}


public class OpenAIResponse
{
    public Message message;
}

public class Message
{
    public string content;
}