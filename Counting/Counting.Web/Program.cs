using Counting.Shared.Services;
using Counting.Web.Client.Services;
using Counting.Web.Components;
using Counting.Web.Services;
using _Imports = Counting.Shared._Imports;
using AppSetting = Counting.Web.Services.AppSetting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
  .AddInteractiveWebAssemblyComponents();

// Add device-specific services used by the Counting.Shared project
builder.Services.AddSingleton<IAppSetting, AppSetting>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseWebAssemblyDebugging();
}
else
{
  app.UseExceptionHandler("/Error", true);
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
  .AddInteractiveWebAssemblyRenderMode()
  .AddAdditionalAssemblies(
    typeof(_Imports).Assembly,
    typeof(Counting.Web.Client._Imports).Assembly);

app.Run();