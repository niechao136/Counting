using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsButton : ComponentBase
{
}

public static class ButtonSize
{
  public const string Small = "s";
  public const string Medium = "m";
  public const string Large = "l";
}

public static class ButtonType
{
  public const string Primary = "primary";
  public const string Secondary = "secondary";
  public const string OnStrong = "on-strong";
  public const string Successful = "successful";
  public const string Error = "error";
  public const string Warning = "warning";
}

public static class ButtonMode
{
  public const string Filled = "filled";
  public const string Outlined = "outline";
  public const string Text = "text";
}