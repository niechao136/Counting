using Microsoft.JSInterop;

namespace Counting.Shared.Utils;

public static class Session
{
  public static async Task DeleteAsync(IJSRuntime jsRuntime, string key)
  {
    await jsRuntime.InvokeVoidAsync("sessionStorage.removeItem", key);
  }

  public static async Task<string> GetAsync(IJSRuntime jsRuntime, string key)
  {
    return await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", key);
  }

  public static async Task SetAsync(IJSRuntime jsRuntime, string key, string value)
  {
    await jsRuntime.InvokeVoidAsync("sessionStorage.setItem", key, value);
  }
}