namespace Counting.Shared.Services;

public interface IAuthService
{
    public Task LoginAsync(string token);
    public Task LogoutAsync();
    public Task<string> GetTokenAsync();
}
