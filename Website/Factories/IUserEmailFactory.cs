using Roblox.Platform.Membership;

namespace Roblox.Website.Factories
{
    public interface IUserEmailFactory
    {
        IUserEmail GetCurrentVerified(IUser user);
        IUserEmail GetByEmail(string email);
    }
}
