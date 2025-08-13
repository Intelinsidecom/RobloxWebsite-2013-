using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Globalization;
using Roblox.Web.StaticContent;

namespace Roblox.Website.UserControls
{
    public partial class SignupForm : System.Web.UI.UserControl
    {

        public SignupForm()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                HandlePostBack();
                return;
            }

            FillDropDowns();
        }

        protected void HandlePostBack()
        {
            byte gender = (byte)(MaleBtn.Checked ? 2 : FemaleBtn.Checked ? 3 : 1);
            string name = UserName.Text;
            string pass = Request.Form["pass"];
            string passConfirm = Request.Form["passConfirm"];

           
        }

        protected void FillDropDowns()
        {
            switch (Request["gender"])
            {
                case "MaleBtn":
                    MaleBtn.Checked = true;
                    break;
                case "FemaleBtn":
                    FemaleBtn.Checked = true;
                    break;
            }
        }
    }
}