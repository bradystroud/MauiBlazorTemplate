using MauiBlazor.UI.Core.Interfaces;

namespace MauiBlazor.UI.Web.Services;

public class PlatformService : IPlatformService
{
    public string GetPlatformName() => "Web";
}
