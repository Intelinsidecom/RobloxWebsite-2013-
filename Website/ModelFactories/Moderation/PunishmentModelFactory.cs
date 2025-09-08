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
            return new PunishmentModel
            {
                ID = 0,
                Action = punishment.Type.ToString(),
                ModeratorID = 0,
                ModeratorName = moderator?.Name ?? "Moderator",
                InternalNote = null,
                ModeratorMessage = null,
                Created = DateTime.UtcNow,
                Expiration = null
            };
        }

        public static IList<PunishmentModel> PopulatePunishmentModels(long userId)
        {
            var punishmentModels = new List<PunishmentModel>();
            var punishments = Punishment.GetUserPunishmentsPaged(userId, 0, 256).Reverse();

            foreach (var punishment in punishments)
            {
                IUser moderator = _userFactory.GetCurrentUser();
                var punishmentModel = PopulatePunishmentModel(punishment, moderator);

                punishmentModels.Add(punishmentModel);
            }

            return punishmentModels;
        }
    }
}