using Counting.Shared.Services;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Infrastructure;

namespace Counting.Web.Client.Services;

public class AuthService(SessionService session) : IAuthService
{
  private SessionService Session { get; } = session;

  public async Task LoginAsync(string token)
  {
    await Session.SetAsync("token", token);
  }

  public async Task LogoutAsync()
  {
    await Session.DeleteAsync("token");
  }

  public async Task<string> GetTokenAsync()
  {
    var value = await Session.GetAsync("token");
    return value;
  }
}

public class SessionService(IJSRuntime jsRuntime)
{
  public async Task DeleteAsync(string key)
  {
    await jsRuntime.InvokeVoidAsync("sessionStorage.removeItem", key);
  }

  public async Task<string> GetAsync(string key)
  {
    var value = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", key);
    return value;
  }

  public async Task SetAsync(string key, string value)
  {
    await jsRuntime.InvokeVoidAsync("sessionStorage.setItem", key, value);
  }
}

public class MyJsRuntime : JSRuntime
{
  protected override void BeginInvokeJS(long taskId, string identifier, string? argsJson, JSCallResultType resultType,
    long targetInstanceId)
  {
  }

  protected override void EndInvokeDotNet(DotNetInvocationInfo invocationInfo,
    in DotNetInvocationResult invocationResult)
  {
  }
}