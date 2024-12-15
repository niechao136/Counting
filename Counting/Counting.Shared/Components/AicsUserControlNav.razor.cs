using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsUserControlNav : ComponentBase
{
}

public class UserAction
{
  public string GroupName { get; set; } = string.Empty;
  public List<string> Actions { get; set; } = [];
  public string Action { get; set; } = string.Empty;
}

public class UserFooter
{
  public string WebVersion { get; set; } = string.Empty;
  public string ServerVersion { get; set; } = string.Empty;
}
