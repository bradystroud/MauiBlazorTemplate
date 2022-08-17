using MauiBlazor.UI.Core.Interfaces;
using MauiBlazor.UI.Core.Services;
using MauiBlazor.UI.Web;
using MauiBlazor.UI.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
builder.Services.AddScoped(_ => httpClient);
builder.Services.AddScoped<IPlatformService, PlatformService>();
builder.Services.AddScoped<IWeatherForecastClient>(_ => new WeatherForecastClient(builder.Configuration["ApiUrl"], httpClient));

await builder.Build().RunAsync();
