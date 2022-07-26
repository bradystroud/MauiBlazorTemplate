using SharedUI.Interfaces;

namespace BlazorApp.Services
{
    public class PlatformService : IPlatformService
    {
        public string GetPlatformName() => "Web";
    }
}
