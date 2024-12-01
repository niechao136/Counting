using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsLayout : ComponentBase
{
}

public class LayoutFooter
{
  public string WebVersion { get; set; } = string.Empty;
  public string ServerVersion { get; set; } = string.Empty;
  public string Copyright { get; set; } = string.Empty;
}
