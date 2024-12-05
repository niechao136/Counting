using Counting.Shared.Services;

namespace Counting.Web.Client.Services;

public class AppSetting(IConfiguration configuration) : IAppSetting
{
  public string Get(string key)
  {
    return configuration[key] ?? string.Empty;
  }
}