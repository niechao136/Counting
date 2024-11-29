using Counting.Shared.Services;
using Microsoft.Extensions.Configuration;

namespace Counting.Services;

public class AppSetting(IConfiguration configuration) : IAppSetting
{
  public string Get(string key)
  {
    return configuration[key] ?? "";
  }
}