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

public static class TooltipTheme
{
  public const string Dark = "dark";
  public const string Light = "light";
}

public class DomRect
{
  public double Bottom { get; set; }
  public double Left { get; set; }
  public double Right { get; set; }
  public double Top { get; set; }
  public double Width { get; set; }
  public double Height { get; set; }
  public double WindowWidth { get; set; }
  public double WindowHeight { get; set; }
  public double X { get; set; }
  public double Y { get; set; }
}
