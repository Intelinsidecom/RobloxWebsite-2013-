using System;
using System.Resources;
using Roblox.Website.ViewModels.Users;

namespace Roblox.Website.UserControls.UserContent
{
    public partial class UserBadgesPane : System.Web.UI.UserControl
    {
        public ProfileViewModel UserProfile;
        public RobloxResourceSet Resources;

        /*private int TotalSoloVisits
        {
            get
            {
                return IncrementalStatisticsAggregation.GetPlaceVisitsSoloAggregateCount();
            }
        }*/
        /*private int TotalMulitVisits
        {
            get
            {
                return IncrementalStatisticsAggregation.GetPlaceVisitsMultiplayerAggregateCount();
            }
        }*/

        protected void OnPreRender(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserProfile == null)
                return;
            Resources = UserProfile.ProfileLangResources;
        }

        protected void AwardUserBadges()
        {
            AwardCommunityBadges();
        }

        protected void AwardCommunityBadges()
        {
            // UserPointSummary.Get
            AwardFriendshipBadges();
        }

        protected void AwardFriendshipBadges()
        {
            // _User.TotalNumberOfFriends
            AwardCombatBadges();
            AwardVisitsBadges();
        }

        protected void AwardCombatBadges()
        {
            // KillsCounter.GetOrCreate
            // DeathsCounter.GetOrCreate
        }

        protected void AwardVisitsBadges()
        {
            // TotalSoloVisits
            // TotalMulitVisits
        }
    }
}