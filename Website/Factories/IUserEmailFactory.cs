using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Platform.Email.User;

namespace Roblox.Website.Factories
{
    public interface IUserEmailFactory
    {
        IAccountEmail GetCurrentVerified(IUser user);
        IAccountEmail GetByEmail(string email);
        ICollection<IAccountEmail> GetEmailsForUser(long userId);
    }
}
