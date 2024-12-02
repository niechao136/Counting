using Newtonsoft.Json;

namespace Counting.Shared.Services;

public class ApiClient(HttpClient client)
{
  public async Task<string> PostAsync(string url, object? body = null)
  {
    var result = "{}";
    var response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(body ?? new { })));
    if (response.IsSuccessStatusCode)
    {
      result = await response.Content.ReadAsStringAsync();
    }
    return result;
  }
}

public class PosClient(HttpClient client)
{
  public HttpClient Client { get; set; } = client;
}
