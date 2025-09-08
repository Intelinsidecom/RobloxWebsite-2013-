using Roblox.Platform.Email.User;
using Roblox.Platform.Membership;

namespace Roblox.Website.Factories
{
    public class EmailDomainFactories
    {
        public EmailDomainFactories(object logger = null)
        {
            UserEmailFactory = new DefaultUserEmailFactory();
        }

        public IUserEmailFactory UserEmailFactory { get; }

        private class DefaultUserEmailFactory : IUserEmailFactory
        {
            public IUserEmail GetByEmail(string email)
            {
                return null;
            }

            public IUserEmail GetCurrentVerified(IUser user)
            {
                return null;
            }
        }
    }
}
