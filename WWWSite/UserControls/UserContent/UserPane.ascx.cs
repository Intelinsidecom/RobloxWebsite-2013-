using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels.Users;
using Roblox.Website.ViewModels.Users.Shared;
using Roblox.Web.StaticContent;

namespace Roblox.Website.UserControls.UserContent
{
    public partial class UserPane : System.Web.UI.UserControl
    {
        public ProfileViewModel UserProfile;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserProfile == null)
                return;

            //RobloxCSS.PageCSS.Add("~/CSS/Pages/User/UserPane.css");


            if (UserProfile.MayEdit)
            {
                onlineStatusRow.Visible = false;
                lnkPublicView.NavigateUrl = String.Format(lnkPublicView.NavigateUrl, UserProfile.ProfileUserId);
                pnlViewPublic.Visible = true;
                AbuseReportButton.Visible = false;
            }
            else

            // User status stuff
            // This code should hopefully last
            switch (UserProfile.UserPrecenceType)
            {
                case PresenceType.Offline:
                    lUserOnlineStatus.CssClass = "UserOfflineMessage";
                    break;
                case PresenceType.Online:
                    lUserOnlineStatus.CssClass = "UserOnlineMessage";
                    break;
                case PresenceType.InGame:
                    UserOnlineStatusHyperLink.NavigateUrl = UserProfile.AbsolutePlaceUrl; // /Pacifico-New-Pizza-Restaurant-with-Job-place?id=85440715
                    break;
            }

            // Avatar thumbnail
            // TODO: Use AvatarImage class in Roblox.Thumbs
            //AvatarImage.UserID = profile.ProfileUserId; // ??
            AvatarImage.ImageUrl = "~/Images/Accounts/boy.png";
            AvatarImage.AlternateText = UserProfile.ProfileDisplayName;

            if (UserProfile.CanSeePrimaryGroup)
            {
                // TODO: Use AssetImage class in Roblox.Thumbs
                //PrimaryGroupAssetImage.AssetID = profile.PrimaryGroupId; // TODO: Get Group Emblem from Group ID
                PrimaryGroupAssetImage.NavigateUrl = String.Format(PrimaryGroupAssetImage.NavigateUrl, UserProfile.PrimaryGroupId);
                HyperLink1.NavigateUrl = String.Format(HyperLink1.NavigateUrl, UserProfile.PrimaryGroupId);
            }

            if (!String.IsNullOrEmpty(UserProfile.PreviousUserNames))
            {
                PreviousUserNames.Visible = true;
            }

            Alerts1.Visible = UserProfile.MayEdit;
            Alerts1.UserID = UserProfile.ProfileUserId;
            rbxPublicUser.UserProfile = UserProfile;
        }
    }
}