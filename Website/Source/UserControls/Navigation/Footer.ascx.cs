using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.UserControls.Navigation
{
    public partial class Footer : System.Web.Mvc.ViewUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            YearLabel.Text = DateTime.Now.Year.ToString();
        }
    }
}