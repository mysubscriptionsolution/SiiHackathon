using Microsoft.Playwright;
using System.Buffers.Text;

namespace SiiHackathon.Tests
{
    [TestFixture]
    public class BaseTest
    {
        private IBrowser _browser;
        private IPage _page;
        private IPlaywright _playwright;
        private string _baseUrl = "http://54.37.131.9/";

        [SetUp]
        public async Task SetUp()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            _page = await _browser.NewPageAsync();

        }

        [TearDown]
        public async Task TearDown()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }

    }
}
