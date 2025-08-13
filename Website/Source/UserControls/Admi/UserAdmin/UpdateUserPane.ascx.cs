using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels.Admi.UserAdmin;

namespace Roblox.Website.UserControls.Admi.UserAdmin
{
    // TODO: Ugly, burn it all and redo
    public partial class UpdateUserPane : System.Web.UI.UserControl
    {
        public UpdateUserViewModel Model { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ViewState["AccountID"] = Model.ID;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            UpdateUserTable.DataBind();
        }

        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {
            /*int ID = (int)ViewState["AccountID"];

            // Update blurb
            var blurb = txtUserBlurb.Text.Trim();
            var account = Roblox.Account.Get(ID);
            if (account.Description != blurb)
            {
                account.Description = blurb;
                account.Save();
            }

            // Update email address
            AccountEmailAddress.CreateNew(ID, lblEmail.Text);

            var password = txtPassword.Text;
            if (!string.IsNullOrEmpty(password))
            {
                // Don't allow updating of the ROBLOX account's password
                if (ID != Roblox.User.RobloxAccount.AccountID)
                {
                    // Update account password
                    var passwordHash = PasswordHash.HashPassword(password);
                    AccountPasswordHash.CreateNew(ID, passwordHash);
                }
            }*/
        }
    }
}