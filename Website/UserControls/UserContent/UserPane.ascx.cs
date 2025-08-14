using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels.Users;
using Roblox.Website.ViewModels.Users.Shared;
using Roblox.Web.StaticContent;
using Roblox.Web.Code;

namespace Roblox.Website.UserControls.UserContent
{
    public partial class UserPane : System.Web.UI.UserControl
    {
        public ProfileViewModel UserProfile;
        public RobloxResourceSet Resources;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserProfile == null)
                return;

            RobloxCSS.PageCSS.Add("~/CSS/Pages/User/UserPane.css");

            Resources = UserProfile.ProfileLangResources;

            if (UserProfile.MayEdit)
            {
                lUserRobloxURL.Text = Resources["HeadingYourProfile"];
                onlineStatusRow.Visible = false;
                lnkPublicView.Text = Resources["ActionViewPublicProfile"];
                lnkPublicView.NavigateUrl = String.Format(lnkPublicView.NavigateUrl, UserProfile.ProfileUserId);
                pnlViewPublic.Visible = true;
                AbuseReportButton.Visible = false;
            }
            else
                lUserRobloxURL.Text = String.Format(Resources["HeadingUsersProfile"], UserProfile.ProfileDisplayName);

            // User status stuff
            // This code should hopefully last
            switch (UserProfile.UserPrecenceType)
            {
                case PresenceType.Offline:
                    lUserOnlineStatus.Text = String.Format(Resources["LabelOnlineStatus"], Resources["LabelOffline"]);
                    lUserOnlineStatus.CssClass = "UserOfflineMessage";
                    break;
                case PresenceType.Online:
                    lUserOnlineStatus.Text = String.Format(Resources["LabelOnlineStatusDetailed"], Resources["LabelOnline"], UserProfile.LastLocation);
                    lUserOnlineStatus.CssClass = "UserOnlineMessage";
                    break;
                case PresenceType.InGame:
                    UserOnlineStatusHyperLink.Text = String.Format(Resources["LabelOnlineStatusDetailed"], Resources["LabelOnline"], UserProfile.LastLocation);
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
                PreviousUserNames.Text = Resources["DescriptionChangedUsernames"] + " <img class='tooltip-bottom' style='cursor:pointer;' src='http://images.rbxcdn.com/d3246f1ece35d773099f876a31a38e5a.png' title='" + Resources["Label.PastUsernames"] + ": " + UserProfile.PreviousUserNames + "'/>";
            }

            Alerts1.Visible = UserProfile.MayEdit;
            Alerts1.UserID = UserProfile.ProfileUserId;
            rbxPublicUser.UserProfile = UserProfile;
        }
    }
}