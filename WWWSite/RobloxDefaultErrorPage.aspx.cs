using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Diagnostics;

namespace Roblox.Website
{
    public partial class RobloxDefaultErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Guid ID;
            string Mode = Request["Mode"] ?? "";
            HttpStatusCode Code;
            string errorMsg = null;

            // If no valid GUID is set, we'll generate a new one
            /*if (!Guid.TryParse(Request["ID"], out ID))
                ID = Guid.NewGuid();*/

            if (!Enum.TryParse(Request["Code"], out Code))
                // If no valid code is set, we'll return an internal server error just to be safe
                Code = HttpStatusCode.InternalServerError;
            else if (GetLocalResourceObject("Errors." + (int)Code + ".Title") == null)
                // If a code is set, but it isn't valid, we'll return a bad request error
                Code = HttpStatusCode.BadRequest;

            if (Guid.TryParse(Request["ID"], out ID))
            {
                // TODO: figure out a better way that doesn't involve making a completely new log
                System.Diagnostics.EventLog log = new System.Diagnostics.EventLog("Roblox");
                var entries = log.Entries.Cast<EventLogEntry>()
                         .Where(x => x.Source == ID.ToString())
                         .Select(x => new
                         {
                             x.Message
                         }).ToList();
                if (entries.Count > 0)
                {
                    // Get the error message from the event log.
                    errorMsg = entries.First().Message;
                }
            }

            ErrorTitle.Text = GetLocalResourceObject("Errors." + (int)Code + ".Title").ToString();
            ErrorMessage.Text = GetLocalResourceObject("Errors." + (int)Code + ".Message").ToString();
            // Error ID should be loaded from DB and error should be displayed here
            errorMsgLbl.Text = (errorMsg != null ? errorMsg : "");

            //CS email link
            CustomerServiceMessage.Text = String.Format(CustomerServiceMessage.Text, "<span class=\"SL_swap\" id=\"CsEmailLink\"><a href=\"mailto:info@roblox.com\">info@roblox.com</a></span>");
            // Set the response status code to match the error
            Response.StatusCode = (int)Code;
            Response.TrySkipIisCustomErrors = true;
        }
    }
}