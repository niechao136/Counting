using System.Security.Claims;
using Counting.Shared.Services;
using Microsoft.AspNetCore.Components.Authorization;

namespace Counting.Web.Services;

public class AuthService : IAuthService
{

    private AuthState State { get; } = new();

    public Task LoginAsync(string token)
    {
        var identity = new ClaimsIdentity([
            new Claim("token", token),
            new Claim("time", GetTimeStamp())
        ], "Counting");
        State.CurrentUser = new ClaimsPrincipal(identity);
        return Task.CompletedTask;
    }

    public Task LogoutAsync()
    {
        State.CurrentUser = new ClaimsPrincipal();
        return Task.CompletedTask;
    }

    public Task<string> GetTokenAsync()
    {
        var token = State.CurrentUser.Claims.SingleOrDefault(o => o.Type == "token")?.Value;
        if (string.IsNullOrEmpty(token)) return Task.FromResult(string.Empty);
        var ts = State.CurrentUser.Claims.SingleOrDefault(o => o.Type == "time")?.Value;
        return Task.FromResult(IsExpired(ts) ? string.Empty : token);
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

public class AuthStateProvider : AuthenticationStateProvider
{
    private AuthenticationState _state;

    public AuthStateProvider(AuthState authState)
    {
        _state = new AuthenticationState(authState.CurrentUser);

        authState.UserChanged += principal =>
        {
            _state = new AuthenticationState(principal);
            NotifyAuthenticationStateChanged(Task.FromResult(_state));
        };
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync() => Task.FromResult(_state);

}

public class AuthState
{
    public event Action<ClaimsPrincipal>? UserChanged;
    private ClaimsPrincipal? _currentUser;

    public ClaimsPrincipal CurrentUser
    {
        get => _currentUser ?? new ClaimsPrincipal();
        set
        {
            _currentUser = value;
            UserChanged?.Invoke(_currentUser);
        }
    }

}
