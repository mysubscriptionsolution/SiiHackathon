using Microsoft.Playwright;
using SiiHackathon.Models.DataModels;

namespace SiiHackathon.Pages.Sections.OrderCheckoutSections
{
    internal class AddressSection(IPage page) : OrderSectionBase(page)
    {
        protected override ILocator SectionLocator => _page.Locator("#checkout-addresses-step");

        ILocator addressAlias => SectionLocator.Locator("#field-alias");
        ILocator firstNameInput => SectionLocator.Locator("#field-firstname");
        ILocator lastNameInput => SectionLocator.Locator("#field-lastname");
        ILocator addressInput => SectionLocator.Locator("#field-address1");
        ILocator cityInput => SectionLocator.Locator("#field-city");
        ILocator stateDropdown => SectionLocator.Locator("#field-id_state");
        ILocator postalCodeInput => SectionLocator.Locator("#field-postcode");
        ILocator countryDropdown => SectionLocator.Locator("#field-id_country");

        public async Task FillInAddressForm(OrderAddress orderAddress, bool continueToNextStep = true)
        {
            await addressAlias.FillAsync(orderAddress.AddressAlias);
            await firstNameInput.FillAsync(orderAddress.FirstName);
            await lastNameInput.FillAsync(orderAddress.LastName);
            await addressInput.FillAsync(orderAddress.Address);
            await cityInput.FillAsync(orderAddress.City);
            if (!string.IsNullOrEmpty(orderAddress.State))
            {
                await stateDropdown.SelectOptionAsync(new SelectOptionValue() { Label = orderAddress.State });
            }
            await postalCodeInput.FillAsync(orderAddress.PostalCode);
            await countryDropdown.SelectOptionAsync(new SelectOptionValue() { Label = orderAddress.Country });

            if (continueToNextStep)
            {
                await ContinueToNextStep();
            }
        }

        public async Task DeleteExistingAddress(string addressName)
        {
            var existingAddress = SectionLocator.Locator("article").Filter(new() { HasTextString = addressName });
            if (!await existingAddress.IsVisibleAsync())
            {
                return;
            }

            ILocator deleteButton = existingAddress.Locator(".delete-address");
            await deleteButton.ClickAsync();
        }
    }
}
