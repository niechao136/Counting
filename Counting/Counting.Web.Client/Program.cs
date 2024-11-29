using Counting.Shared.Services;
using Counting.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the Counting.Shared project
builder.Services.AddSingleton<IAppSetting, AppSetting>();

await builder.Build().RunAsync();
