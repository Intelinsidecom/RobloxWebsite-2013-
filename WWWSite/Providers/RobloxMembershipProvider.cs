using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

using Roblox.Hashing;
using Roblox.Platform.Authentication;
using Roblox.Platform.Membership;

namespace Roblox.Website.Providers
{
    public class RobloxMembershipProvider : MembershipProvider
    {
        private readonly IUserFactory _UserFactory = Global.MembershipDomainFactories.UserFactory;

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

                if (GetUser(username) != null)
                {
                    status = MembershipCreateStatus.DuplicateUserName;
                    return null;
                }

                

              
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
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline = false)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override bool ValidateUser(string username, string password)
        {
            return false;
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