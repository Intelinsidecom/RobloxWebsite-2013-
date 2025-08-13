using System;
using Roblox.Platform.Email;

namespace Roblox.Platform.Email
{
    public class UserEmail : IUserEmail
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Email { get; set; }
        public bool IsVerified { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public UserEmail()
        {
            Created = DateTime.UtcNow;
            Updated = DateTime.UtcNow;
        }

        public UserEmail(long id, long userId, string email, bool isVerified)
        {
            Id = id;
            UserId = userId;
            Email = email;
            IsVerified = isVerified;
            Created = DateTime.UtcNow;
            Updated = DateTime.UtcNow;
        }
    }
}
