using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Roblox.Moderation;
using Roblox.Platform.Membership;

namespace Roblox.Website.Admi.Users
{
    public partial class ModerateUser : System.Web.UI.Page
    {
        private static IUserFactory _userFactory;

        public string _AbuseType = "Privacy";
        public string _UtteranceSourceType = "UserStatus";

        public IUser IUser { get; private set; }
        public long UserID { get; private set; }

        static ModerateUser()
        {
            _userFactory = Global.MembershipDomainFactories.UserFactory;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            long id;
            if (!long.TryParse(Request["ID"], out id))
                id = 1;
            IUser = _userFactory.GetUser(id);
            UserID = IUser.Id;

            PopulateDataFields();
        }

        /// <summary>
        /// Populates all of the data fields on the form
        /// </summary>
        protected void PopulateDataFields()
        {
            pnlPageHeader.DataBind();
            rblModerationAction.DataSource = PunishmentType.AllPunishmentTypes;
            rblModerationAction.DataBind();
            tblModerationControls.DataBind();
            rbxModerationCard.DataBind();
            rbxCheatDetections.DataBind();
            rbxPunishmentsPane.DataBind();
        }
    }
}