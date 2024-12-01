using Counting.Shared.Services;
using Counting.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var config = builder.Configuration;

// Add device-specific services used by the Counting.Shared project
builder.Services.AddSingleton<IAppSetting, AppSetting>();
builder.Services.AddScoped<ApiClient>(_ => new ApiClient(new HttpClient
{
  BaseAddress = new Uri(config["URL:API"] ?? builder.HostEnvironment.BaseAddress)
}));
builder.Services.AddScoped<PosClient>(_ => new PosClient(new HttpClient
{
  BaseAddress = new Uri(config["URL:POS"] ?? builder.HostEnvironment.BaseAddress)
}));

await builder.Build().RunAsync();
