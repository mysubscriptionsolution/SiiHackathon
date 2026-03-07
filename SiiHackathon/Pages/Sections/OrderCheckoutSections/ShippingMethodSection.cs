using Microsoft.Playwright;

namespace SiiHackathon.Pages.Sections.OrderCheckoutSections
{
    internal class ShippingMethodSection(IPage page) : BasePage(page)
    {
        ILocator shippingMethodSection => _page.Locator("#checkout-delivery-step");

        public async Task ChooseShippingMethod(string shippingMethodName)
        {
            var shippingMethodOption = shippingMethodSection.GetByRole(AriaRole.Radio, new() { Name = shippingMethodName });
            await shippingMethodOption.CheckAsync();
            await shippingMethodSection.GetByRole(AriaRole.Button, new() { Name = "Continue" }).ClickAsync();
        }
    }
}
