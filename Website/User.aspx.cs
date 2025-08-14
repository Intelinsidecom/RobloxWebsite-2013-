using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Roblox.Website.ViewModels.Users;
using Roblox.Platform.Membership;
using Roblox.Web.StaticContent;
using Roblox.Web.Code;

namespace Roblox.Website
{
    public partial class UserPage : System.Web.UI.Page
    {
        public ProfileViewModel UserProfile { get; set; }
        private IUser _AuthenticatedUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Configure bundles
            // TODO: Separate per-user control
            RobloxCSS.PageCSS.Add("Pages/User/User.css");
            RobloxCSS.PageCSS.Add("Widgets/accordion.css");
            RobloxCSS.PageCSS.Add("Widgets/Points.css");
            RobloxCSS.PageCSS.Add("Pages/Badges/Badges.css");
            RobloxCSS.PageCSS.Add("Pages/Inventory/Inventory.css");
            RobloxCSS.PageCSS.Add("Pages/Universes/PlaceSelectorModal.css");

            RobloxScripts.PageScripts.Add("/js/SuperSafePrivacyIndicator.js"); // TODO: /js/SuperSafePrivacyIndicator.js
            RobloxScripts.PageScripts.Add("jquery.simplemodal-1.3.5.js");
            RobloxScripts.PageScripts.Add("GenericModal.js");
            RobloxScripts.PageScripts.Add("DataPager.js");
            RobloxScripts.PageScripts.Add("Sets/SetsPane.js");
            RobloxScripts.PageScripts.Add("extensions/string.js");
            RobloxScripts.PageScripts.Add("widgets/accordion.js");
            RobloxScripts.PageScripts.Add("UserPlacesPane.js");
            RobloxScripts.PageScripts.Add("ItemPurchase.js");
            RobloxScripts.PageScripts.Add("modules/Widgets/ItemImage.js");
            RobloxScripts.PageScripts.Add("Universes/PlaceSelectorModal.js");
            RobloxScripts.PageScripts.Add("UserAssetsPane.js");
            RobloxScripts.PageScripts.Add("CreateSetPanel.js");
            RobloxScripts.PageScripts.Add("fileUploadUnsupported.js");


            UserProfile = GetProfileViewModel();

            // User was not found
            if (UserProfile == null)
                throw new HttpException(404, "Not found");

            Page.Title = UserProfile.ProfileDisplayName;

            // Pass profile view model to user controls
            rbxHeaderPane.UserProfile = UserProfile;
            rbxUserPane.UserProfile = UserProfile;
            rbxUserBadgesPane.UserProfile = UserProfile;
            rbxUserGroupsPane.UserProfile = UserProfile;
            rbxUserStatisticsPane.UserProfile = UserProfile;
            rbxSetsPane.UserProfile = UserProfile;

            rbxUserPlacesPane.Model = new UserPlacesViewModel()
            {
                UserID = UserProfile.ProfileUserId,
                AuthenticatedUser = _AuthenticatedUser
            };
        }

        /// <summary>
        /// Attempts to get the <see cref="IUser"/> based on info specified in the query parameters.
        /// Uses the current user if one couldn't be found.
        /// </summary>
        /// <returns>Whether or not the required query parameters were present.</returns>
        private bool GetUserFromQuery(out IUser user)
        {
            var userFactory = Global.MembershipDomainFactories.UserFactory;

            user = null;

            int userId;
            string userId_str = Request["ID"];
            string username = Request["Name"];

            if (int.TryParse(userId_str, out userId))
            {
                user = userFactory.GetUser(userId);
                return true;
            }
            else if (!string.IsNullOrEmpty(username))
            {
                user = userFactory.GetUserByName(username);
            }
            return false;
        }

        /// <summary>
        /// Gets whether the displayed user's page should be editable by the viewer.
        /// This checks the "ForcePublicView" query parameter against the result and returns accordingly.
        /// </summary>
        /// <param name="viewer">The <see cref="IUser"/> of the viewer.</param>
        /// <param name="viewee">The <see cref="IUser"/> of the user who owns the profile page.</param>
        /// <returns>Whether the viewer can edit the current profile.</returns>
        private bool GetMayEdit(IUser viewer, IUser viewee)
        {
            bool mayEdit = viewee.Equals(viewer);
            bool desiresPublicView = false;

            if (mayEdit)
                Boolean.TryParse(Request["ForcePublicView"], out desiresPublicView);

            return mayEdit && !desiresPublicView;
        }

        private ProfileViewModel GetProfileViewModel()
        {
            var userFactory = Global.MembershipDomainFactories.UserFactory;

            _AuthenticatedUser = userFactory.GetCurrentUser();
            IUser displayedUser;

            if (GetUserFromQuery(out displayedUser))
            {
                if (displayedUser == null)
                {
                    // The query params were provided, but we just couldn't find the user
                    return null;
                }
            }
            else
            {
                // No query params were provided, use the authenticated user as a last resort
                if (Page.User.Identity.IsAuthenticated)
                {
                    displayedUser = _AuthenticatedUser;
                }
                else
                {
                    FormsAuthentication.RedirectToLoginPage();
                    return null;
                }
            }

            return new ProfileViewModel(displayedUser, _AuthenticatedUser, GetMayEdit(_AuthenticatedUser, displayedUser));
        }
    }
}