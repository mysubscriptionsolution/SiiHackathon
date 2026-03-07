using Microsoft.Playwright;

namespace SiiHackathon.Tests
{
    [TestFixture]
    public class BaseTest
    {
        private IBrowser _browser;
        private IBrowserContext _context;
        protected IPage _page;
        private IPlaywright _playwright;
        private const string _baseUrl = "http://54.37.131.9/";

        [SetUp]
        public async Task SetUp()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            _context = await _browser.NewContextAsync(new BrowserNewContextOptions
            {
                BaseURL = _baseUrl
            });
            _page = await _context.NewPageAsync();
            await _page.GotoAsync("/");
        }

        [TearDown]
        public async Task TearDown()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }
    }
}
