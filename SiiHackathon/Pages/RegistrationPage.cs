using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class RegistrationPage(IPage page) : BasePage(page)
    {
        private ILocator FirstNameInput => _page.Locator("#field-firstname");
        private ILocator LastNameInput => _page.Locator("#field-lastname");
        private ILocator EmailInput => _page.Locator("#field-email");
        private ILocator PasswordInput => _page.Locator("#field-password");
        private ILocator AgreeTermsCheckboxt => _page.GetByRole(AriaRole.Checkbox, new () { Name = "I agree to the terms and" });
        private ILocator CustomerDataPrivacyInput => _page.GetByText("The personal data you provide");
        private ILocator SaveButton => _page.GetByRole(AriaRole.Button, new() { Name = "Save" });

        public async Task FillInRegisterForm(string firstName, string lastName, string email, string password)
        {
            await FirstNameInput.FillAsync(firstName);
            await LastNameInput.FillAsync(lastName);
            await EmailInput.FillAsync(email);
            await PasswordInput.FillAsync(password);
            await AgreeTermsCheckboxt.CheckAsync();
            await CustomerDataPrivacyInput.CheckAsync();
        }

        public async Task<LoggedInPage> ClickSave()
        {
            await SaveButton.ClickAsync();
            return new LoggedInPage(_page);
        }

    }
}
