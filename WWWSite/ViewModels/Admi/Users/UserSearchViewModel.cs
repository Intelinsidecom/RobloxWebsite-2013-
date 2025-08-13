using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Website.Models.Moderation;

namespace Roblox.Website.ViewModels.Admi.Users
{
    public class UserSearchViewModel
    {
        /// <summary>
        /// The username of the user to search for
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The ID of the user to search for
        /// </summary>
        public int? UserID { get; set; }

        /// <summary>
        /// The email address of the user to search for
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The users matching the search criteria
        /// </summary>
        public IEnumerable<PunishableUserModel> Users { get; set; }
    }
}