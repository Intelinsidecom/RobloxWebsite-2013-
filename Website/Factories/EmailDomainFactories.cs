using Roblox.Platform.Email.User;
using Roblox.Platform.Membership;

namespace Roblox.Website.Factories
{
    public interface IUserEmailFactory
    {
        IAccountEmail GetByEmail(string email);
        IAccountEmail GetCurrentVerified(IUser user);
    }

    public class EmailDomainFactories
    {
        public EmailDomainFactories(object logger = null)
        {
            UserEmailFactory = new DefaultUserEmailFactory();
        }

        public IUserEmailFactory UserEmailFactory { get; }

        private class DefaultUserEmailFactory : IUserEmailFactory
        {
            public IAccountEmail GetByEmail(string email)
            {
                return null;
            }

            public IAccountEmail GetCurrentVerified(IUser user)
            {
                return null;
            }
        }
    }
}
