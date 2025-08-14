using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using Roblox.Website.ViewModels.Users.Shared; // temporary?
using Roblox.Platform.Membership;

namespace Roblox.Website.ViewModels.Users
{
    /// <summary>
    /// Contains all of the info shared between the WebForms page,
    /// UserControls, View, and PartialViews.
    /// </summary>
    public class ProfileViewModel
    {
        public long UserId { get; set; }
        public long ProfileUserId { get; set; }
        public string ProfileUserName { get; set; }
        public string ProfileDisplayName { get; set; }
        public int FriendsCount { get; set; }
        public PresenceType UserPrecenceType { get; set; }
        public string LastLocation { get; set; }
        public string UserStatus { get; set; }
        public DateTime UserStatusDate { get; set; }
        public long? UserPlaceId { get; set; }
        public int FollowersCount { get; set; }
        public int FollowingsCount { get; set; }
        public string AcceptFriendRequestUrl { get; set; }
        public int IncomingFriendRequestId { get; set; }
        public string FollowersWidgetUrl { get; set; }
        public string FollowingsWidgetUrl { get; set; }
        public bool IsVieweeBlocked { get; set; }
        public bool IsViewerBlocked { get; set; }
        public string FriendUrl { get; set; }
        public bool AreFriends { get; set; }
        public bool IncomingFriendRequestPending { get; set; }
        public bool MaySendFriendInvitation { get; set; }
        public bool FriendRequestPending { get; set; }
        public string SendFriendRequestUrl { get; set; }
        public string RemoveFriendRequestUrl { get; set; }
        public bool MayFollow { get; set; }
        public bool IsFollowing { get; set; }
        public string FollowUrl { get; set; }
        public string UnFollowUrl { get; set; }
        public bool CanMessage { get; set; }
        public bool MessagesDisabled { get; set; }
        public string MessageUrl { get; set; }
        public bool CanBeFollowed { get; set; }
        public bool CanPartyWithUser { get; set; }
        public bool CanChatWithUser { get; set; }
        public bool CanTrade { get; set; }
        public bool CanSeeFavorites { get; set; }
        public bool IsBlockButtonVisible { get; set; }
        public string GetFollowScript { get; set; }
        public bool IsMoreBtnVisible { get; set; }
        public bool MayImpersonate { get; set; }
        public string ImpersonateUrl { get; set; }
        public bool MayEdit { get; set; }
        public string UpdateStatusUrl { get; set; }
        public int EditStatusMaxLength { get; set; }
        public object HeadShotImage { get; set; }
        public string FavoritesUrl { get; set; }
        public string AbsolutePlaceUrl { get; set; }
        public bool IsChatDisabledByPrivacySetting { get; set; }
        public string PreviousUserNames { get; set; }
        public bool IsUserOnPhone { get; set; }
        public bool CanSeeInventory { get; set; }
        public string InventoryUrl { get; set; }
        public RobloxResourceSet ProfileLangResources { get; set; }
        public bool IsVieweePremiumOnlyUser { get; set; }
        public bool IsDisplayNamesEnabled { get; set; }
        public bool IsChinaRealNameVerified { get; set; }
        public string ChinaRealNameVerifiedText { get; set; }
        public bool IsUserStatusDisabled { get; set; }
        // The old becomes new
        public bool CanSeePoints { get; set; }
        public int UserPoints { get; set; }
        public int ClanPoints { get; set; }
        public bool CanSeePrimaryGroup { get; set; }
        public int PrimaryGroupId { get; set; }
        public string PrimaryGroupName { get; set; }
        public string ProfileDescription { get; set; }
        public bool IsVieweeTopFriend { get; set; }

        public ProfileViewModel(IUser user, IUser viewer, bool mayEdit = false)
        {
            // Set up presence view model
            PresenceViewModel presence = new PresenceViewModel(user);

            // Set up profile view model
            UserId = (viewer != null ? viewer.Id : 0);
            ProfileUserId = user.Id;
            ProfileUserName = user.Name;
            ProfileDisplayName = user.Name;
            ProfileDescription = user.Description;
            FriendsCount = 0; // TODO: pull from db
            UserPrecenceType = presence.UserPresenceType;
            LastLocation = presence.LastLocation;
            UserStatus = ""; // TODO: pull from db
            UserStatusDate = DateTime.MinValue; // TODO: pull from db
            UserPlaceId = presence.PlaceId;
            FollowersCount = 0;
            FollowingsCount = 0;
            FollowersWidgetUrl = "";
            FollowingsWidgetUrl = "";
            IsVieweeBlocked = false;
            IsViewerBlocked = false;
            FriendUrl = ""; // TODO: pull from settings
            AreFriends = false; // run check via Friendship BIZ
            IsVieweeTopFriend = false; // FriendInvitation check??
            IncomingFriendRequestPending = false; // ^
            MaySendFriendInvitation = true; // pivacy setting check on profile user?
            FriendRequestPending = false; // FriendInvitation check
            MayFollow = false; // social follow
            IsFollowing = false;
            CanMessage = false; // privacy setting check on profile user?
            MessagesDisabled = false; // privacy setting check?
            MessageUrl = ""; // pull from settings
            CanBeFollowed = false; // follow into game
            CanTrade = false; // privacy setting
            CanSeeFavorites = false; // privacy setting?
            IsBlockButtonVisible = false;
            GetFollowScript = presence.UserPresenceType == PresenceType.InGame ? $"RobloxLaunch.RequestFollowUser('PlaceLauncherStatusPanel', '{UserId}')" : ""; // pull from settings?
            IsMoreBtnVisible = false; // I think this is old. also, does this depend on the number of enabled buttons?
            MayImpersonate = false; // dunno how old this is. always false?
            MayEdit = mayEdit; // enabled when viewer is viewee
            UpdateStatusUrl = mayEdit ? "/home/updatestatus" : ""; // was blank for viewer in 2021 is "/home/updatestatus" for viewee
            EditStatusMaxLength = 254; // pull from settings
            FavoritesUrl = ""; // pull from settings
            AbsolutePlaceUrl = presence.AbsolutePlaceUrl;
            IsChatDisabledByPrivacySetting = false; // privacy setting for viewer only? (IsAppChatSettingEnabled from my/account/json maybe?)
            PreviousUserNames = ""; // "PreviousUserNames":"CloneTrooper1019\r\nDogeTrooper1019\r\nCloneTrooper1019\r\nDogeTropper1019\r\nDogeTrooper1019\r\nChangedUsernameAlot\r\nCloneTrooper1019\r\nNotCloneTrooper1019\r\nCloneTrooper1019\r\nNotCloneTrooper1019\r\nCloneTrooper1019\r\nMAX_GEE\r\nCloneTrooper_1019\r\nCloneTrooper1019\r\nMAX_GEE\r\nPegboard_Nerds\r\nCloneTrooper1019\r\nHL3_Confirmed\r\nCloneTrooper1019\r\nMAX_G\r\nCloneTrooper1019\r\nMaximum_ADHD\r\nCloneTrooper1019\r\nMaximum_ADHD"
            IsUserOnPhone = false; // viewer or viewee?
            CanSeeInventory = false; // viewee privacy setting
            InventoryUrl = ""; // pull from settings
            ProfileLangResources = new RobloxResourceSet("Feature.Profile");
            IsVieweePremiumOnlyUser = false; // true for ROBLOX account
            IsDisplayNamesEnabled = false;
            IsChinaRealNameVerified = false; // unused
            ChinaRealNameVerifiedText = "Real Name Verified"; // pull from resource file?
            IsUserStatusDisabled = true; // always disabled for whatever reason
        }
    }
}