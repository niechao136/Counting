using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsButton : ComponentBase
{
    
}

public enum ButtonSize
{
    Small = 12,
    Medium = 14,
    Large = 16
}

public enum ButtonType
{
    Primary = 0,
    Secondary = 1,
    OnStrong = 2,
    Successful = 3,
    Error = 4,
    Warning = 5
}

public enum ButtonMode
{
    Filled = 0,
    Outlined = 1,
    Text = 2
}
