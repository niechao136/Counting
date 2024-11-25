using Counting.Shared.Services;

namespace Counting.Web.Services;

public class CountingConfig(IConfiguration configuration) : ICountingConfig
{
    public string GetConfig(string key)
    {
        return configuration[key] ?? "";
    }
}
