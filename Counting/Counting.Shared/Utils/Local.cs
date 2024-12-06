using Microsoft.JSInterop;

namespace Counting.Shared.Utils;

public class Local
{
  public static async Task DeleteAsync(IJSRuntime jsRuntime, string key)
  {
    await jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
  }

  public static async Task<string> GetAsync(IJSRuntime jsRuntime, string key)
  {
    return await jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
  }

  public static async Task SetAsync(IJSRuntime jsRuntime, string key, string value)
  {
    await jsRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
  }
}