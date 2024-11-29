using System.Reflection;
using Counting.Services;
using Counting.Shared.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Counting;

public static class MauiProgram
{
  public static MauiApp CreateMauiApp()
  {
    var builder = MauiApp.CreateBuilder();
    builder.UseMauiApp<App>().ConfigureFonts(fonts =>
    {
      fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
    });

    // appsetting config
    var assembly = Assembly.GetExecutingAssembly();
    using var stream = assembly.GetManifestResourceStream("Counting.appsettings.json");
    var config = new ConfigurationBuilder()
      .AddJsonStream(stream!)
      .Build();
    builder.Configuration.AddConfiguration(config);

    // Add device-specific services used by the Counting.Shared project
    builder.Services.AddSingleton<IAppSetting, AppSetting>();
    builder.Services.AddSingleton<IAuthService, AuthService>();

    builder.Services.AddMauiBlazorWebView();

#if DEBUG
    builder.Services.AddBlazorWebViewDeveloperTools();
    builder.Logging.AddDebug();
#endif

    return builder.Build();
  }
}