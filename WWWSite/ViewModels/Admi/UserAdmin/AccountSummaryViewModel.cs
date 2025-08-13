using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.ViewModels.Admi.UserAdmin
{
    public class AccountSummaryViewModel
    {
        /// <summary>
        /// The ID of the user
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// The name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The moderation status of the user's account
        /// </summary>
        public string ModerationStatus { get; set; }

        /// <summary>
        /// Whether or not the user is currently subscribed to a valid premium membership
        /// </summary>
        public bool IsPremiumUser { get; set; }

        /// <summary>
        /// The user's premium membership type
        /// </summary>
        public string MembershipType { get; set; }

        /// <summary>
        /// The user's premium membership expiration date
        /// </summary>
        public string MembershipExpirationDate { get; set; }

        /// <summary>
        /// The user's premium membership auto-renewal date
        /// </summary>
        public string MembershipRenewalDate { get; set; }

        /// <summary>
        /// The date the user first subscribed to Builders' Club
        /// </summary>
        public string LoyalSinceDate { get; set; }

        /// <summary>
        /// The current location of the user on the site
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The ID of the user to be used for search
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// The name of the user to be used for search
        /// </summary>
        public string UserName { get; set; }
    }
}