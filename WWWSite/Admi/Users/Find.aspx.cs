using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ModelFactories.Moderation;
using Roblox.Website.ViewModels.Admi.Users;

namespace Roblox.Website.Admi.Users
{
    public partial class Find : System.Web.UI.Page
    {
        public UserSearchViewModel Model { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            var userName = Request["UserName"];
            var userId = string.IsNullOrEmpty(Request["UserID"]) ? null : (int?)Convert.ToInt32(Request["UserID"]);
            var emailAddress = Request["Email"];

            if (userName != null || userId != null || emailAddress != null)
            {
                Model = new UserSearchViewModel()
                {
                    UserName = userName,
                    UserID = userId,
                    EmailAddress = emailAddress
                };
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Model != null)
            {
                PopulateUserSearchResults();

                UserSearchGridView.DataSource = Model.Users;
                UserSearchGridView.DataBind();

                btnModerateUsers.Visible = true;
            }
        }

        protected void PopulateUserSearchResults()
        {
            var users = PunishableUserModelFactory.PopulatePunishableUserModels(Model.UserID, Model.UserName, Model.EmailAddress);

            Model.Users = users;
        }

        protected void btnUserNameSearch_Click(object sender, EventArgs e)
        {
            Model = new UserSearchViewModel
            {
                UserName = txtUserName.Text
            };
        }

        protected void btnUserIDSearch_Click(object sender, EventArgs e)
        {
            Model = new UserSearchViewModel
            {
                UserID = string.IsNullOrEmpty(txtUserID.Text) ? null : (int?)Convert.ToInt32(txtUserID.Text)
            };
        }

        protected void btnEmailAddressSearch_Click(object sender, EventArgs e)
        {
            Model = new UserSearchViewModel
            {
                EmailAddress = txtEmailAddress.Text
            };
        }

        protected void btnModerateUsers_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (GridViewRow row in UserSearchGridView.Rows)
                {
                    // TODO: shit system
                    var moderateUser = ((CheckBox)row.Cells[11].FindControl("cbxModerateUser")).Checked;
                    var id = Convert.ToInt32(row.Cells[1].Text);

                    if (moderateUser)
                    {
                        // TODO: Add user to current moderator's queue?
                    }
                }

                Response.Redirect("~/Admi/Users/ModerateUser.aspx", true);
            }
            catch
            {
                // My sandcastle has collapsed :(
            }
        }
    }
}