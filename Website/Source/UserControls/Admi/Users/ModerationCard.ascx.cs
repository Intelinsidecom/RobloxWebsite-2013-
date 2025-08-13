using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Platform.Membership;
using Roblox;

namespace Roblox.Website.UserControls.Admi.Users
{
    public partial class ModerationCard : System.Web.UI.UserControl
    {
        private static IUserFactory _userFactory;

        public int UserID { get; set; }

        public string UserName { get; private set; }
        public string MembershipText { get; private set; }
        public string OnlineStatusImageUrl { get; private set; }
        public string LocationText { get; private set; }
        public string ModerationStatus { get; private set; }
        public int? RobuxCount { get; private set; }
        public int? TicketsCount { get; private set; }
        public int? MessageCount { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string AgeBracket { get; private set; }

        static ModerationCard()
        {
            _userFactory = Global.MembershipDomainFactories.UserFactory;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            var user = _userFactory.MustGetUser(UserID);

            UserName = user.Name;
            MembershipText = "Free Member";
            OnlineStatusImageUrl = "~/images/offline.png";
            LocationText = "[ Offline ]";
            ModerationStatus = AccountStatus.MustGet((byte)user.AccountStatus).Value;
            MessageCount = 0;
            CreatedDate = user.Created;
            AgeBracket = user.AgeBracket == Roblox.Platform.Membership.AgeBracket.Age13OrOver ? "Over 13" : "Under 13";

            DataBind();
        }
    }
}