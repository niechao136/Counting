using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsInputText : ComponentBase
{
}

public static class InputSize
{
  public const string Small = "s";
  public const string Medium = "m";
}

public static class InputType
{
  public const string Color = "color";
  public const string File = "file";
  public const string Number = "number";
  public const string Password = "password";
  public const string Text = "text";
}

public static class InputAutoComplete
{
  public const string On = "on";
  public const string Off = "off";
}
