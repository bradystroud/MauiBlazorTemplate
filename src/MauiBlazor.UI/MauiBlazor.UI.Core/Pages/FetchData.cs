using Microsoft.AspNetCore.Components;
using MauiBlazor.Shared;
using MauiBlazor.UI.Core.Services;

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