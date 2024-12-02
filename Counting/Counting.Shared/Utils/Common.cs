using Microsoft.JSInterop;

namespace Counting.Shared.Utils;

public static class Common
{
  public static string HandlePath(string path)
  {
    return $"/_content/Counting.Shared/{path}";
  }

  public static bool IsClient(IJSRuntime jsRuntime) =>
    jsRuntime.GetType().ToString().Contains("DefaultWebAssemblyJSRuntime");

}