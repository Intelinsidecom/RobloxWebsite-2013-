using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.Models.Moderation
{
    public class PunishmentModel
    {
        /// <summary>
        /// The ID of the punishment
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// The moderation action
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// The reason for the moderation action
        /// </summary>
        public string PunishmentReasonType { get; set; }

        /// <summary>
        /// The username of the moderator who enacted the punishment
        /// </summary>
        public string ModeratorName { get; set; }

        /// <summary>
        /// The ID of the moderator who enacted the punishment
        /// </summary>
        public int ModeratorID { get; set; }

        /// <summary>
        /// The internal note written by the moderator who enacted the punishment
        /// </summary>
        public string InternalNote { get; set; }

        /// <summary>
        /// The user-facing note written to the user who received the punishment
        /// </summary>
        public string ModeratorMessage { get; set; }

        /// <summary>
        /// The created date of the punishment entity
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The expiration date of the punishment
        /// </summary>
        public DateTime? Expiration { get; set; }
    }
}