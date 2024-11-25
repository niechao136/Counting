using Counting.Shared.Services;
using Microsoft.Extensions.Configuration;

namespace Counting.Services;

public class CountingConfig(IConfiguration configuration) : ICountingConfig
{
    public string GetConfig(string key)
    {
        return configuration[key] ?? "";
    }
}
