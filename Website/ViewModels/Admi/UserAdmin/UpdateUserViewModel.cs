using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.ViewModels.Admi.UserAdmin
{
    public class UpdateUserViewModel
    {
        /// <summary>
        /// The ID of the account to update
        /// </summary>
        /// <remarks>
        /// This field is readonly
        /// </remarks>
        public long ID { get; set;  }

        /// <summary>
        /// The user's blurb
        /// </summary>
        public string Blurb { get; set; }

        /// <summary>
        /// The email address associated with the user's account
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Whether or not the user's email address is verified/validated
        /// </summary>
        /// <remarks>
        /// This field is readonly
        /// </remarks>
        public bool IsEmailVerified { get; set; }

        /// <summary>
        /// The user's password (should only be able to update and NOT VIEW this field)
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The created date for the user's account entity
        /// </summary>
        /// <remarks>
        /// This field is readonly
        /// </remarks>
        public DateTime Created { get; set; }

        /// <summary>
        /// The last location of the user. e.g. Website
        /// </summary>
        /// <remarks>
        /// This field is readonly
        /// </remarks>
        public string LastLocation { get; set; }

        /// <summary>
        /// The date of the user's last detected activity
        /// </summary>
        /// <remarks>
        /// This field is readonly
        /// </remarks>
        public DateTime? LastActivityDate { get; set; }

        /// <summary>
        /// Whether or not the user's account has been approved by moderation
        /// </summary>
        /// <remarks>
        /// This field is readonly
        /// </remarks>
        public bool IsApproved { get; set; }
    }
}