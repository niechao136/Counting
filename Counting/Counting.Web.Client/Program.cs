using Counting.Shared.Services;
using Counting.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MauiApp8.Shared project
builder.Services.AddSingleton<IAuthService, AuthService>();

await builder.Build().RunAsync();
