using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.ViewModels.Admi.UserAdmin
{
    public class UserNoteModel
    {
        /// <summary>
        /// The ID of the user note
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// The user note contents
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The username of the moderator who created the user note
        /// </summary>
        public string ModeratorName { get; set; }

        /// <summary>
        /// The user ID of the moderator who created the user note
        /// </summary>
        public long ModeratorID { get; set; }

        /// <summary>
        /// The date the user note was created
        /// </summary>
        public DateTime Created { get; set; }
    }
}