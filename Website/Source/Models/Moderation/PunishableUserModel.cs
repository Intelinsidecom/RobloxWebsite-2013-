using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.Models.Moderation
{
    public class PunishableUserModel
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
        /// Whether or not the user is online
        /// </summary>
        public bool IsOnline { get; set; }

        /// <summary>
        /// The email address associated with the user's account
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The name of the user's primary RoleSet
        /// </summary>
        public string RoleSet { get; set; }

        /// <summary>
        /// The created date for the user's entity
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The date of the user's last detected activity
        /// </summary>
        public DateTime? LastActivityDate { get; set; }

        /// <summary>
        /// Whether or not the user's account has been approved by moderation
        /// </summary>
        /// <remarks>
        /// This field is readonly
        /// </remarks>
        public bool IsApproved { get; set; }

        /// <summary>
        /// The last location of the user. e.g. Website
        /// </summary>
        /// <remarks>
        /// This field is readonly
        /// </remarks>
        public string LastLocation { get; set; }

        /// <summary>
        /// The user's premium membership type
        /// </summary>
        public string MembershipType { get; set; }

        /// <summary>
        /// The moderation status of the user's account
        /// </summary>
        public string ModerationStatus { get; set; }
    }
}