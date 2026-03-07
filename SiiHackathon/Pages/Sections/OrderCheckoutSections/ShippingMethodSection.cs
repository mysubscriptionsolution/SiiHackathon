using Microsoft.Playwright;

namespace SiiHackathon.Pages.Sections.OrderCheckoutSections
{
    internal class ShippingMethodSection(IPage page) : OrderSectionBase(page)
    {
        protected override ILocator SectionLocator => _page.Locator("#checkout-delivery-step");

        public async Task ChooseShippingMethod(string shippingMethodName, bool continueToNextStep = true)
        {
            var shippingMethodOption = SectionLocator.GetByRole(AriaRole.Radio, new() { Name = shippingMethodName });
            await shippingMethodOption.CheckAsync();

            if (continueToNextStep)
            {
                await ContinueToNextStep();
            }
        }
    }
}
