using Microsoft.Playwright;
using SiiHackathon.Models.DataModels;

namespace SiiHackathon.Pages.Sections.OrderCheckoutSections
{
    internal class AddressSection(IPage page) : BasePage(page)
    {
        ILocator addressSection => _page.Locator("#checkout-addresses-step");
        ILocator firstNameInput => addressSection.Locator("#field-firstname");
        ILocator lastNameInput => addressSection.Locator("#field-lastname");
        ILocator addressInput => addressSection.Locator("#field-address1");
        ILocator cityInput => addressSection.Locator("#field-city");
        ILocator stateDropdown => addressSection.Locator("#field-id_state");
        ILocator postalCodeInput => addressSection.Locator("#field-postcode");
        ILocator countryDropdown => addressSection.Locator("#field-id_country");

        public async Task FillInAddressForm(OrderAddress orderAddress, bool continueToNextStep = true)
        {
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
                await addressSection.GetByRole(AriaRole.Button, new() { Name = "Continue" }).ClickAsync();
            }
        }
    }
}
