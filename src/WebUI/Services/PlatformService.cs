using UI.Shared.Interfaces;

namespace WebUI.Services
{
    public class PlatformService : IPlatformService
    {
        public string GetPlatformName() => "Web";
    }
}
