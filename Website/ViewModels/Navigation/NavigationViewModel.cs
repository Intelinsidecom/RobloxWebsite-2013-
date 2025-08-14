using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Platform.Membership;

namespace Roblox.Website.ViewModels.Navigation
{
    public class NavigationViewModel
    {
        public IUser User { get; }
        public RobloxResourceSet LangResourceSet { get; }


        public NavigationViewModel()
        {
            User = Global.MembershipDomainFactories.UserFactory.GetCurrentUser();
            LangResourceSet = new RobloxResourceSet("CommonUI.Features");
        }
    }
}