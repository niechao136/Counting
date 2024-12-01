namespace Counting.Shared.Services;

public class ApiClient(HttpClient client)
{
  public HttpClient Client { get; set; } = client;
}

public class PosClient(HttpClient client)
{
  public HttpClient Client { get; set; } = client;
}
