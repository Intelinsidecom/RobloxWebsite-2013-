using Roblox.Platform.Membership;

namespace Roblox.Website.Factories
{
    public class EmailAddress
    {
        public string Address { get; set; }
        public EmailAddress(string address) { Address = address; }
    }

    public interface IUserEmail
    {
        string Email { get; }
        bool IsValid { get; }
        EmailAddress EmailAddress { get; }
    }
}
