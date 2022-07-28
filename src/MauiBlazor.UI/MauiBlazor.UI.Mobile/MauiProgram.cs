using MauiBlazor.UI.Core.Interfaces;
using MauiBlazor.UI.Core.Services;
using MauiBlazor.UI.Mobile.Services;
/* Unmerged change from project 'MauiBlazor.UI.Mobile(net6.0-ios)'
Before:
namespace MauiBlazor.UI.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            var httpClient = new HttpClient();

            builder.Services.AddScoped<IWeatherForecastClient>(_ => new WeatherForecastClient("https://localhost:7136", httpClient));
            builder.Services.AddScoped<IPlatformService, PlatformService>();


            return builder.Build();
        }
After:
namespace MauiBlazor.UI.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        var httpClient = new HttpClient();

        builder.Services.AddScoped<IWeatherForecastClient>(_ => new WeatherForecastClient("https://localhost:7136", httpClient));
        builder.Services.AddScoped<IPlatformService, PlatformService>();


        return builder.Build();
*/

/* Unmerged change from project 'MauiBlazor.UI.Mobile(net6.0-maccatalyst)'
Before:
namespace MauiBlazor.UI.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            var httpClient = new HttpClient();

            builder.Services.AddScoped<IWeatherForecastClient>(_ => new WeatherForecastClient("https://localhost:7136", httpClient));
            builder.Services.AddScoped<IPlatformService, PlatformService>();


            return builder.Build();
        }
After:
namespace MauiBlazor.UI.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        var httpClient = new HttpClient();

        builder.Services.AddScoped<IWeatherForecastClient>(_ => new WeatherForecastClient("https://localhost:7136", httpClient));
        builder.Services.AddScoped<IPlatformService, PlatformService>();


        return builder.Build();
*/


namespace MauiBlazor.UI.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        var httpClient = new HttpClient();

        builder.Services.AddScoped<IWeatherForecastClient>(_ => new WeatherForecastClient("https://localhost:7136", httpClient));
        builder.Services.AddScoped<IPlatformService, PlatformService>();


        return builder.Build();
    }
}
