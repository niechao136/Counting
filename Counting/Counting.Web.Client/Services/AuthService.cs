using Counting.Shared.Services;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Infrastructure;

namespace Counting.Web.Client.Services;

public class AuthService : IAuthService
{

    private readonly SessionService _session = new(new MyJsRuntime());

    public async Task LoginAsync(string token)
    {
        await _session.SetAsync("token", token);
    }

    public async Task LogoutAsync()
    {
        await _session.DeleteAsync("token");
    }

    public async Task<string> GetTokenAsync()
    {
        return await _session.GetAsync("token");
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
        return await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", key);
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

    protected override void EndInvokeDotNet(DotNetInvocationInfo invocationInfo, in DotNetInvocationResult invocationResult)
    {
    }

}
