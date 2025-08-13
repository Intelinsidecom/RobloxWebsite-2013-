using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.UserControls
{
    public partial class VisitButtons : System.Web.UI.UserControl
    {
        public IAsset Place { get; set; }
        public bool CanMPVisit { get; set; }
        public bool CanBuild { get; set; }
        public bool CanEdit { get; set; }
        public string FancyButtonsClassName { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            FancyButtonsClassName = "VisitButtonsLeft ";
            if (!(CanBuild && CanEdit))
                FancyButtonsClassName += "Centered";
        }
    }
}