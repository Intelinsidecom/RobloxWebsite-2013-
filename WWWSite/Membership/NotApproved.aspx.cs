using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Roblox.Moderation;

namespace Roblox.Website
{
    public partial class NotApproved : System.Web.UI.Page
    {
        public string TitleText { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsBanished { get; set; } = false;
        public string PunishmentDurationString { get; set; } = string.Empty;
        public Punishment Punishment { get; set; }

        private ICollection<Punishment> _punishments;

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
                Response.Redirect("~/Login/Default.aspx", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Page.Title = "ROBLOX | Disabled Account";
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/", true);
        }

        protected void ButtonAgree_Click(object sender, EventArgs e)
        {
            

            Response.Redirect("~/", true);
        }
    }
}