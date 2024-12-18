using Counting.Shared.Stores;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

  public static async Task LoginAsync(IJSRuntime jsRuntime, string value)
  {
    await SetAsync(jsRuntime, "BLAZOR_COUNTING_TOKEN", value);
    var res = JsonConvert.DeserializeObject<JObject>(value);
    LoginStore.Token.OnNext(res?["token"] ?? null);
    LoginStore.UserId.OnNext(res?["user_id"]?.ToString() ?? string.Empty);
  }
  public static async Task InitAsync(IJSRuntime jsRuntime)
  {
    var str = await GetAsync(jsRuntime, "BLAZOR_COUNTING_TOKEN");
    if (!string.IsNullOrEmpty(str))
    {
      var res = JsonConvert.DeserializeObject<JObject>(str);
      LoginStore.Token.OnNext(res?["token"] ?? null);
      LoginStore.UserId.OnNext(res?["user_id"]?.ToString() ?? string.Empty);
    }
  }
}