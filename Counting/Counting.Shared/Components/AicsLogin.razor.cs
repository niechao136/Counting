using Microsoft.AspNetCore.Components;

namespace Counting.Shared.Components;

public partial class AicsLogin : ComponentBase
{
}

public class LoginFooter
{
  public string WebVersion { get; set; } = "1.0.0.4";
  public string ServerVersion { get; set; } = "1.0.0.4";
  public string Copyright { get; set; } = "\u00a9 2024 Advantech Intelligent City Services Co., Ltd. (AiCS) All Rights Reserved.";
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
  public bool RememberMe { get; set; }
  public string ErrorMessage { get; set; } = string.Empty;
}
