using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsLayout : ComponentBase
{
}

public class HeaderBreadcrumb
{
  public string Text { get; set; } = string.Empty;
  public bool Disabled { get; set; }
}
