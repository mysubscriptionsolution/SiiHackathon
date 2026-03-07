using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiiHackathon.Pages
{
    internal class RegistrationPage : BasePage
    {
        public RegistrationPage(IPage page) : base(page)
        {
        }

        private ILocator FirstNameInput => _page.Locator("#field-firstname");
        private ILocator LastNameInput => _page.Locator("#field-lastname");
        private ILocator EmailInput => _page.Locator("#field-email");
        private ILocator PasswordInput => _page.Locator("#field-password");
        private ILocator AgreeTermsCheckboxt => _page.Locator("#field-email");
        private ILocator CustomerDataPrivacyInput => _page.Locator("[@name='customer_privacy']");
        private ILocator SaveButton => _page.GetByText("Save");

        public async Task FillInRegisterForm(string firstName, string lastName, string email, string password)
        {
            await FirstNameInput.FillAsync(firstName);
            await LastNameInput.FillAsync(lastName);
            await EmailInput.FillAsync(email);
            await PasswordInput.FillAsync(password);
            await AgreeTermsCheckboxt.CheckAsync();
            await CustomerDataPrivacyInput.CheckAsync();
            await SaveButton.ClickAsync();
        }

        public async Task ClickSave()
        {
            await SaveButton.ClickAsync();
        }
    }
}
