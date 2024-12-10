using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsIcon : ComponentBase
{
}

public class IconSrc
{
  public string Normal { get; set; } = string.Empty;
  public string Hover { get; set; } = string.Empty;
  public string Active { get; set; } = string.Empty;
  public string Disable { get; set; } = string.Empty;
}