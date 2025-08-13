using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox.Platform.Authentication
{
    public interface ICredentialValidator
    {
        CredentialValidationResult ValidateCredentials(Credentials credentials);
        bool ValidatePassword(long userId, string password);
        bool ValidateEmail(long userId, string email);
    }

    public class CredentialValidationResult
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
        public List<string> ValidationErrors { get; set; } = new List<string>();
    }

    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
