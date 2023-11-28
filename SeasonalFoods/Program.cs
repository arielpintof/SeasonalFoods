using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using SeasonalFoods;
using SeasonalFoods.Service;
using MudExtensions.Services;
using Fluxor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var currentAssembly = typeof(Program).Assembly;
builder.Services.AddFluxor(options => options.ScanAssemblies(currentAssembly));
builder.Services.AddMudServices();
builder.Services.AddMudExtensions();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:27017/")});
builder.Services.AddSingleton<AdvancedSearchService>();
builder.Services.AddHttpClient<IAdvancedSearchService, AdvancedSearchService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:27017/");
});

await builder.Build().RunAsync();