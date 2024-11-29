using Counting.Shared.Services;

namespace Counting.Services;

public class AuthService : IAuthService
{
  public async Task LoginAsync(string token)
  {
    await SecureStorage.Default.SetAsync("auth_token", token);
    await SecureStorage.Default.SetAsync("auth_time", GetTimeStamp());
  }

  public Task LogoutAsync()
  {
    SecureStorage.Default.Remove("auth_token");
    return Task.CompletedTask;
  }

  public async Task<string> GetTokenAsync()
  {
    var token = await SecureStorage.Default.GetAsync("auth_token");
    if (string.IsNullOrEmpty(token)) return string.Empty;
    var ts = await SecureStorage.Default.GetAsync("auth_time");
    return IsExpired(ts) ? string.Empty : token;
  }

  private static string GetTimeStamp()
  {
    var ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0);
    return Convert.ToInt64(ts.TotalSeconds).ToString();
  }

  private static bool IsExpired(string? ts)
  {
    var now = GetTimeStamp();
    return Convert.ToInt64(now) - Convert.ToInt64(ts) > 24 * 60 * 60;
  }
}