using WebUI;
using WebUI.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UI.Shared.Interfaces;
using UI.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
builder.Services.AddScoped(_ => httpClient);
builder.Services.AddScoped<IPlatformService, PlatformService>();
builder.Services.AddScoped<IWeatherForecastClient>(_ => new WeatherForecastClient("https://localhost:7136", httpClient));

await builder.Build().RunAsync();
