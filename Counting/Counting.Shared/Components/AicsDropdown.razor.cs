using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsDropdown : ComponentBase
{
}

public static class DropdownSize
{
  public const string Small = "s";
  public const string Medium = "m";
}

public static class DropdownMode
{
  public const string Text = "text";
  public const string Icon = "icon";
  public const string Outline = "outline";
}

public class DropdownText
{
  public string SelectAll { get; set; } = "All";
  public string MaxElement { get; set; } = "options be selected, please remove selected item before select a new item";
  public string NoResult { get; set; } = "Can't find select item , please search again";
  public string NoOption { get; set; } = "Option lists is empty";
}

public class DropdownSingle
{
  public string Key { get; set; } = string.Empty;
  public string Value { get; set; } = string.Empty;
}

public class DropdownOption : DropdownSingle
{
  public string GroupName { get; set; } = string.Empty;
  public List<DropdownSingle> List { get; set; } = [];
  public string GroupMode { get; set; } = CheckboxMode.Normal;
}

public class DropdownIcon
{
  public string SelectedString { get; set; } = string.Empty;
  public IconSrc SelectedObject { get; set; } = new();
  public string UnselectedString { get; set; } = string.Empty;
  public IconSrc UnselectedObject { get; set; } = new();
}
