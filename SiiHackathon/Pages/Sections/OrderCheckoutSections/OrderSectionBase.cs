using Microsoft.Playwright;

namespace SiiHackathon.Pages.Sections.OrderCheckoutSections
{
    internal abstract class OrderSectionBase(IPage page) : BasePage(page)
    {
        protected virtual ILocator SectionLocator { get; }
        protected ILocator ContinueButton => SectionLocator.GetByRole(AriaRole.Button, new() { Name = "Continue" });

        protected async Task ContinueToNextStep()
        {
            await ContinueButton.ClickAsync();
        }
    }
}
