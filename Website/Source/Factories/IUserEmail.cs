using System;

namespace Roblox.Platform.Email
{
    public interface IUserEmail
    {
        long Id { get; }
        long UserId { get; }
        string Email { get; }
        bool IsVerified { get; }
        DateTime Created { get; }
        DateTime Updated { get; }
    }
}
