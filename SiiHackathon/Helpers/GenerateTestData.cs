namespace SiiHackathon.Helpers
{
    public static class GenerateTestData
    {
        public static string GenerateRandomEmail()
        {
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string email = new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray()) + "@example.com";
            return email;
        }

        public static string GenerateRandomPassword()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            Random random = new Random();
            string password = new string(Enumerable.Repeat(chars, 12)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }

        public static string GenerateRandomName()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            string name = new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return name;
        }
    }
}
