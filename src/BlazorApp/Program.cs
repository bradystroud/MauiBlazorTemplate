using BlazorApp;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedUI.Interfaces;
using SharedUI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var client = new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)};
builder.Services.AddScoped(sp => client);
builder.Services.AddScoped<IPlatformService, PlatformService>();
builder.Services.AddScoped<IWeatherForecastClient>(_ => new WeatherForecastClient("https://localhost:7136", client));

await builder.Build().RunAsync();
