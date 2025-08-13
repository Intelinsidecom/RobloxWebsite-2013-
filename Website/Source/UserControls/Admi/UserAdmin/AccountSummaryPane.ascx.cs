using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels.Admi.UserAdmin;

namespace Roblox.Website.UserControls.Admi.UserAdmin
{
    public partial class AccountSummaryPane : System.Web.UI.UserControl
    {
        public AccountSummaryViewModel Model { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            AccountSummaryFormView.DataSource = new[] { Model };
            AccountSummaryFormView.DataBind();
        }

        protected void btnUserIDSearch_Click(object sender, EventArgs e)
        {
            // Should maybe ~/Admi/Users/Find.aspx in the future
            // Formatting ???
            Response.Redirect(String.Format("~/Admi/Users/Find.aspx?UserID={0}",
                    ((TextBox)((Button)sender).Parent.FindControl("txtUserID")).Text)
            );
        }

        protected void btnUserNameSearch_Click(object sender, EventArgs e)
        {
            // Formatting ???
            Response.Redirect(String.Format("~/Admi/Users/Find.aspx?UserName={0}",
                ((TextBox)((Button)sender).Parent.FindControl("txtUserName")).Text)
            );
        }

        protected void lbModerateUser_Click(object sender, EventArgs e)
        {
            // TODO: Add user to current moderator's queue and redirect them to ~/Admi/Users/ModerateUser.aspx
            Response.Redirect("~/Admi/Users/ModerateUser.aspx", true);
        }
    }
}