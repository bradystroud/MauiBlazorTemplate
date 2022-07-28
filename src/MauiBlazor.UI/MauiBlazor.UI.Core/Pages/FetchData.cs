using MauiBlazor.Shared;
using MauiBlazor.UI.Core.Services;
using Microsoft.AspNetCore.Components;

namespace MauiBlazor.UI.Core.Pages;

public partial class FetchData
{
    [Inject]
    public IWeatherForecastClient Client { get; set; }

    private List<WeatherForecast>? forecasts;

    protected override async Task OnInitializedAsync()
    {
        var result = await Client.GetAsync();
        forecasts = result.ToList();
    }
}
