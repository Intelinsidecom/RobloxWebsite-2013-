using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.ViewModels.Admi.UserAdmin
{
    public class UserNotesViewModel
    {
        public int UserID { get; set; }
        public IEnumerable<UserNoteModel> UserNotes { get; set; }
    }
}