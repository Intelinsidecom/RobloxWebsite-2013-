using System;
using Roblox.Platform.Email;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Email
{
    public interface IUserEmailFactory
    {
        IUserEmail GetCurrentVerified(IUser user);
        IUserEmail GetByEmail(string email);
        ICollection<IUserEmail> GetEmailsForUser(long userId);
    }
}
