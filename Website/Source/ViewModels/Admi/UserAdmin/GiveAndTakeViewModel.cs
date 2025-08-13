using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.ViewModels.Admi.UserAdmin
{
    public class GiveAndTakeViewModel
    {
        /// <summary>
        /// The ID of the user
        /// </summary>
        public long ID { get; set;  }

        /// <summary>
        /// The amount of ROBUX the user currently owns
        /// </summary>
        public int Robux { get; set; }

        /// <summary>
        /// The maximum amount of ROBUX the user has ever owned at one point
        /// </summary>
        public int MaxRobux { get; set; }

        /// <summary>
        /// The amount of Tx the user currently owns
        /// </summary>
        public int Tickets { get; set; }

        /// <summary>
        /// The maximum amount of Tx the user has ever owned at one point
        /// </summary>
        public int MaxTickets { get; set; }

        /// <summary>
        /// The amount of USD credited to the user's account
        /// </summary>
        public int Credit { get; set; }

        /// <summary>
        /// The most amount of USD the user has ever had credited to their account at one time
        /// </summary>
        public int MaxCredit { get; set; }
    }
}