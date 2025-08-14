using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Platform.Membership;
using Roblox.Website.ModelFactories.Moderation;

namespace Roblox.Website.UserControls.Admi.Users
{
    public partial class PunishmentsPane : System.Web.UI.UserControl
    {
        public int UserID { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            PunishmentsGridView.DataSource = PunishmentModelFactory.PopulatePunishmentModels(UserID);
            PunishmentsGridView.DataBind();
        }
    }
}