using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsTooltip : ComponentBase
{
}

public static class TooltipPlacement
{
  public const string Top = "top";
  public const string Bottom = "bottom";
  public const string Left = "left";
  public const string Right = "right";
  public const string TopStart = "top-start";
  public const string TopEnd = "top-end";
  public const string BottomStart = "bottom-start";
  public const string BottomEnd = "bottom-end";
  public const string LeftStart = "left-start";
  public const string LeftEnd = "left-end";
  public const string RightStart = "right-start";
  public const string RightEnd = "right-end";
}

public static class TooltipTrigger
{
  public const string Click = "click";
  public const string Focus = "focus";
  public const string Mouseenter = "mouseenter";
}
