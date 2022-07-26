using Microsoft.AspNetCore.Components;
using Shared;
using SharedUI.Services;

namespace SharedUI.Pages;

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