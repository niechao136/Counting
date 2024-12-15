using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsLayoutNav : ComponentBase
{
}

public class NavBase
{
  public string Title { get; set; } = string.Empty;
  public string Href { get; set; } = string.Empty;
}

public class NavSub : NavBase
{
  public string Icon { get; set; } = string.Empty;
  public List<NavBase> Children { get; set; } = [];
}
