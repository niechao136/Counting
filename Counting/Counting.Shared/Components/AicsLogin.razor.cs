using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsLogin : ComponentBase
{
}

public class LoginFooter
{
  public string WebVersion { get; set; } = string.Empty;
  public string ServerVersion { get; set; } = string.Empty;
  public string Copyright { get; set; } = string.Empty;
}

public class LoginText
{
  public string Welcome { get; set; } = "Welcome";
  public string Title { get; set; } = "iService Cloud Platform";
  public string Remember { get; set; } = "Remember Me";
  public string Forget { get; set; } = "Forgot Password";
  public string Account { get; set; } = "Email";
  public string Password { get; set; } = "Password";
  public string Login { get; set; } = "Login";
}

public class LoginForm
{
  public string Account { get; set; } = string.Empty;
  public string Password { get; set; } = string.Empty;
  public string ErrorMessage { get; set; } = string.Empty;
}
