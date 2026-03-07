using Microsoft.Playwright;

namespace SiiHackathon.Clients
{
    public abstract class ApiClientBase
    {
        protected IPlaywright? playwright;
        public abstract string BaseUrl { get; }

        public ApiClientBase()
        {
            playwright = InitializePlaywright();
        }

        public static IPlaywright InitializePlaywright() => Playwright.CreateAsync().Result;
    }
}
