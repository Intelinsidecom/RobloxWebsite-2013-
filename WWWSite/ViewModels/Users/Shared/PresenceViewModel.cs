using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Platform.Membership;

namespace Roblox.Website.ViewModels.Users.Shared
{
    // Temporary
    public enum PresenceType
    {
        Offline = 0,
        Online = 1,
        InGame = 2,
        InStudio = 3
    }
    public class PresenceViewModel
    {
        public PresenceType UserPresenceType { get; }
        public string LastLocation { get; }
        public string AbsolutePlaceUrl { get; }
        public long? PlaceId { get; }
        public Guid? GameId { get; }
        public bool IsGamePlayableOnCurrentDevice { get; }
        public long UserId { get; }
        public string EndpointType => "Presence";

        public PresenceViewModel(IUser user)
        {
            // TODO: fetch Presence info from entity in DB
            UserPresenceType = PresenceType.Offline;
            LastLocation = "Website"; // "Pacifico (New Pizza Restaurant with Job)"
            AbsolutePlaceUrl = ""; // "/Pacifico-New-Pizza-Restaurant-with-Job-place?id=85440715"
            PlaceId = null;
            GameId = null;
            IsGamePlayableOnCurrentDevice = false;
            UserId = user.Id;
        }
    }
}