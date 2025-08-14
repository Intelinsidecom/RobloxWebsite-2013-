using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

using Roblox;
using Roblox.Hashing;
using Roblox.Platform.Authentication;
using Roblox.Platform.Membership;

namespace Roblox.Website.Providers
{
    public class RobloxMembershipProvider : MembershipProvider
    {
        private readonly IUserFactory _UserFactory = Global.MembershipDomainFactories.UserFactory;
        private readonly ICredentialValidator _CredentialValidator = Global.AuthenticationDomainFactories.CredentialValidator;

        public override string ApplicationName { get; set; }

        public override int MinRequiredPasswordLength => 6;

        public override bool RequiresUniqueEmail => true;

        public override bool EnablePasswordRetrieval => false;

        public override string PasswordStrengthRegularExpression => "";

        public override int MinRequiredNonAlphanumericCharacters => 2;

        public override MembershipPasswordFormat PasswordFormat => MembershipPasswordFormat.Hashed;

        public override bool EnablePasswordReset => false;

        public override int PasswordAttemptWindow => 0;

        public override int MaxInvalidPasswordAttempts => 0;

        public override bool RequiresQuestionAndAnswer => false;

        public override MembershipUser CreateUser(string username, string password,
               string email, string passwordQuestion, string passwordAnswer,
               bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            try
            {
                ValidatePasswordEventArgs args =
                   new ValidatePasswordEventArgs(username, password, true);
                OnValidatingPassword(args);

                if (args.Cancel)
                {
                    status = MembershipCreateStatus.InvalidPassword;
                    return null;
                }

                if (!Signup.ValidateUserName(username))
                {
                    status = MembershipCreateStatus.InvalidUserName;
                    return null;
                }

                if (GetUser(username) != null)
                {
                    status = MembershipCreateStatus.DuplicateUserName;
                    return null;
                }

                if (email != null)
                {
                    // Using CredentialValidator to validate email
                    var credentialValidator = Global.AuthenticationDomainFactories.CredentialValidator;
                    // We need a userId for the ValidateEmail method, using 0 as a placeholder
                    if (!credentialValidator.ValidateEmail(0, email))
                    {
                        status = MembershipCreateStatus.InvalidEmail;
                        return null;
                    }

                    if (RequiresUniqueEmail && !Roblox.Signup.CheckEmailUsability(email))
                    {
                        status = MembershipCreateStatus.DuplicateEmail;
                        return null;
                    }
                }

                // Finally create the user
                var passwordHash = HashGenerator.HashString(string.Empty, password);
                Roblox.Signup.CreateNew(username, passwordHash, email);

                // Do this last
                status = MembershipCreateStatus.Success;
                return GetUser(username, true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex);
                status = MembershipCreateStatus.ProviderError;
                return null;
            }
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(string username, bool userIsOnline = false)
        {
            return Roblox.Account.Get(username);
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline = false)
        {
            // This really shouldn't be used...

            int accountId;
            try
            {
                accountId = (int)Convert.ChangeType(providerUserKey, typeof(int));
            }
            catch
            {
                throw new ArgumentException("providerUserKey is of an invalid type");
            }

            var account = Roblox.Account.Get(accountId);
            return account;
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override bool ValidateUser(string username, string password)
        {
            try
            {
                var credentials = new UserCredentials { Username = username, Password = password };
                return _CredentialValidator.ValidateCredentials(credentials).IsValid;
            }
            catch
            {
                return false;
            }
        }

        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            string userName = null;
            var users = Roblox.Account.GetAccountsByEmailAddress(email);

            foreach (var user in users)
            {
                userName = user.UserName;
            }
            return userName;
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
        }
    }
}