using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Platform.Membership;
using Roblox.Platform.Email;
using Roblox.Website.Models.Moderation;

namespace Roblox.Website.ModelFactories.Moderation
{
    public class PunishableUserModelFactory
    {
        private static IUserFactory _userFactory;

        static PunishableUserModelFactory()
        {
            _userFactory = Global.MembershipDomainFactories.UserFactory;
        }

        public static PunishableUserModel PopulatePunishableUserModel(IUser user)
        {

            var model = new PunishableUserModel
            {
                ID = user.Id,
                Name = user.Name,
                IsOnline = false,
                EmailAddress = "example@example.com",
                RoleSet = "",
                Created = user.Created,
                LastActivityDate = null,
                IsApproved = user.AccountStatus == Platform.Membership.AccountStatus.Ok,
                LastLocation = null,
                MembershipType = "None",
                ModerationStatus = user.AccountStatus.ToString()
            };

            return model;
        }

        public static IList<PunishableUserModel> PopulatePunishableUserModels(int? userId, string userName, string emailAddress, int? ipAddress = null)
        {
            var results = new List<PunishableUserModel>();


            return results;
        }
    }
}