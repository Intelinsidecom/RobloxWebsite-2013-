using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Platform.Membership;

namespace Roblox.Website.ViewModels.Users
{
    public class UserPlacesViewModel
    {
        public long UserID { get; set; }
        public ICollection<IAsset> Places { get; set; }
        public int ShowcasePagerPageSize { get; set; }
        public bool DisplayShowcasePager { get; set; }
        public IUser AuthenticatedUser { get; set; }
    }
}