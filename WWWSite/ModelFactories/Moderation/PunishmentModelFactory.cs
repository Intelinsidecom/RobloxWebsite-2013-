using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Moderation;
using Roblox.Platform.Membership;
using Roblox.Website.Models.Moderation;

namespace Roblox.Website.ModelFactories.Moderation
{
    public class PunishmentModelFactory
    {
        private static IUserFactory _userFactory;


        static PunishmentModelFactory()
        {
            _userFactory = Global.MembershipDomainFactories.UserFactory;
        }

        public static PunishmentModel PopulatePunishmentModel(Punishment punishment, IUser moderator)
        {
            throw new NotImplementedException();
        }

        public static IList<PunishmentModel> PopulatePunishmentModels(long userId)
        {
            var punishmentModels = new List<PunishmentModel>();


            return punishmentModels;
        }
    }
}