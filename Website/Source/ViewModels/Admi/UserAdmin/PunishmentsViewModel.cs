using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Website.Models.Moderation;

namespace Roblox.Website.ViewModels.Admi.UserAdmin
{
    public class PunishmentsViewModel
    {
        public IEnumerable<PunishmentModel> Punishments { get; set; }
    }
}