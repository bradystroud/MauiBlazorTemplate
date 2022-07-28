using MauiBlazor.UI.Core.Interfaces;

namespace MauiBlazor.UI.Mobile.Services;
public class PlatformService : IPlatformService
{
    public string GetPlatformName() => DeviceInfo.Current.Platform.ToString();
}
