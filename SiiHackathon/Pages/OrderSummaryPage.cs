using Microsoft.Playwright;
using SiiHackathon.Pages.Sections.OrderCheckoutSections;

namespace SiiHackathon.Pages
{
    internal class OrderSummaryPage(IPage page) : BasePage(page)
    {
        public AddressSection AddressSection => new(_page);
        public ShippingMethodSection ShippingMethodSection => new(_page);
    }
}
