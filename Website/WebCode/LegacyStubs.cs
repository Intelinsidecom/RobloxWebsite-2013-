using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

// Controls namespace expected by auto-generated designer files
namespace Roblox.Controls
{
    public class Panel : System.Web.UI.WebControls.Panel { }
    public class Image : System.Web.UI.WebControls.Image 
    { 
        // Some pages treat Image like a clickable link
        public string NavigateUrl { get; set; }
    }

namespace Roblox.Web.Code.Properties
{
    public static class Settings
    {
        public static class Default
        {
            public static bool IsCookieConstraintEnabled { get; set; } = false;
        }
    }
}

namespace Roblox.Web.Code.CookieConstraint
{
    using System.Web;

    public static class CookieConstraintValidator
    {
        public static bool HasConstrainedCookie(HttpRequestBase request) => true;
    }

    public static class CookieConstraintManager
    {
        public static bool IsRequesterConstrained() => false;
        public static void LiftConstraint(string password, string action) { }
    }
}
}

// Legacy Roblox monolith API stubs used across the site for compilation
namespace Roblox
{
    public class User
    {
        public long ID { get; set; }
        public static User GetByAccountID(int accountId) => new User { ID = accountId };
        public static User GetCurrent() => new User();
    }

    public class Account
    {
        public int ID { get; set; }
        public int AccountStatusID { get; set; } = AccountStatus.OkId;
        public static Account GetCurrent() => new Account();
        public static System.Web.Security.MembershipUser Get(string username) => null;
        public static System.Web.Security.MembershipUser Get(int id) => new System.Web.Security.MembershipUser(
            providerName: "RobloxMembershipProvider",
            name: $"User{id}",
            providerUserKey: id,
            email: null,
            passwordQuestion: null,
            comment: null,
            isApproved: true,
            isLockedOut: false,
            creationDate: DateTime.UtcNow.AddYears(-1),
            lastLoginDate: DateTime.UtcNow.AddDays(-1),
            lastActivityDate: DateTime.UtcNow.AddDays(-1),
            lastPasswordChangedDate: DateTime.UtcNow.AddDays(-30),
            lastLockoutDate: DateTime.MinValue);
        public static IEnumerable<System.Web.Security.MembershipUser> GetAccountsByEmailAddress(string email) => new List<System.Web.Security.MembershipUser>();
    }

    public static class Signup
    {
        public static bool ValidateUserName(string username) => !string.IsNullOrWhiteSpace(username);
        public static bool CheckEmailUsability(string email) => true;
        public static void CreateNew(string username, string passwordHash, string email) {}
    }

    public static class ExceptionHandler
    {
        public static void LogException(Exception ex) { }
    }

    public class AccountStatus
    {
        public static int OkId = 0;
    }

    // Minimal EmailAddress entity used by UserCheckController
    public class EmailAddress
    {
        public bool IsBlacklisted { get; set; } = false;
        public static EmailAddress Get(string email) => string.IsNullOrWhiteSpace(email) ? null : new EmailAddress();
    }

    // Minimal placeholder to satisfy references in admin test page
    public enum AssetType
    {
        Unknown = 0
    }
}

namespace Roblox.Moderation
{
    // Minimal model to satisfy NotApproved page usage
    public class Punishment
    {
        public PunishmentType Type { get; set; } = PunishmentType.Warn;
        public static long GetTotalNumberOfUserPunishments(long userId) => 0;
        public static ICollection<Punishment> GetUserPunishmentsPaged(long userId, int start, int count) => new List<Punishment>();
        public static long GetTotalNumberOfActiveUserPunishments(object user) => 0;
    }

    public enum PunishmentType
    {
        DeleteAccount,
        PoisonMachine,
        Remind,
        Warn
    }

    public static class PunishmentTypeExtensions
    {
        public static ICollection<PunishmentType> AllPunishmentTypes => new List<PunishmentType>
        {
            PunishmentType.DeleteAccount,
            PunishmentType.PoisonMachine,
            PunishmentType.Remind,
            PunishmentType.Warn
        };
    }

    // Minimal stub for user moderation notes used by admin pages
    public class UserModerationNote
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ModeratorID { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;

        public void Save() { /* no-op stub */ }

        public static IList<UserModerationNote> GetUserModerationNotesByUserID(int userId)
        {
            return new List<UserModerationNote>();
        }
    }
}

namespace Roblox.Hashing
{
    public static class HashGenerator
    {
        public static string HashString(string salt, string input)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes((salt ?? string.Empty) + (input ?? string.Empty)));
                var sb = new StringBuilder();
                foreach (var b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}

namespace Roblox.Website
{
    // Listener interface expected by ExceptionHandlerListener
    public interface IExceptionHandlerListener
    {
        void ExceptionLogged();
    }
}
