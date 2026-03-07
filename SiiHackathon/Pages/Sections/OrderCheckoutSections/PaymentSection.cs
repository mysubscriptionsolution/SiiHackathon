using Microsoft.Playwright;

namespace SiiHackathon.Pages.Sections.OrderCheckoutSections
{
    internal class PaymentSection(IPage page) : OrderSectionBase(page)
    {
        protected override ILocator SectionLocator => _page.Locator("#checkout-payment-step");

        public async Task ChoosePaymentMethod(string paymentMethodName)
        {
            var shippingMethodOption = SectionLocator.GetByRole(AriaRole.Radio, new() { Name = paymentMethodName });
            await shippingMethodOption.CheckAsync();
        }
    }
}
