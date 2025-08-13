using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.Login
{
    public partial class ResetPasswordRequest : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
                Response.Redirect("/", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            string message;
            AttemptPasswordReset(out message, UserName.Text);
            PasswordMessage.Text = message;
        }

        protected void UsernamesReminderButton_Click(object sender, EventArgs e)
        {
            string message;
            AttemptUsernamesReminder(out message, UserEmail.Text);
            UsernameMessage.Text = message;
        }

        private bool AttemptPasswordReset(out string message, string username)
        {
            message = "Please enter a valid username";
            if (!string.IsNullOrEmpty(username))
            {
                message = $"Attempted password reset for {username}";
                return true;
            }

            return false;
        }

        private bool AttemptUsernamesReminder(out string message, string emailAddress)
        {
            message = "Please enter a valid email address";
           

            return false;
        }
    }
}