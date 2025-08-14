using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Globalization;
using Roblox.Website.WebCode;
using Roblox.Web.StaticContent;
using Roblox.Web.Code;

namespace Roblox.Website.UserControls
{
    public partial class SignupForm : System.Web.UI.UserControl
    {
        private SignupHelper _helper;

        public SignupForm()
        {
            _helper = new SignupHelper(CultureInfo.CurrentUICulture);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                HandlePostBack();
                return;
            }

            FillDropDowns();
            RobloxCSS.PageCSS.Add("Pages/Signup/Signup.css");
            RobloxScripts.PageScripts.Add("SignupFormValidator.js");
            RobloxScripts.PageScripts.Add("FormValidator.js");
        }

        protected void HandlePostBack()
        {
            byte gender = (byte)(MaleBtn.Checked ? 2 : FemaleBtn.Checked ? 3 : 1);
            string name = UserName.Text;
            string pass = Request.Form["pass"];
            string passConfirm = Request.Form["passConfirm"];

            var status = _helper.DoSignup(
                lstDays.SelectedValue, lstMonths.SelectedValue, lstYears.SelectedValue,
                gender, name, pass, passConfirm
            );

            Response.Redirect(_helper.GetRedirectUrlForSignupStatus(status), true);
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

            // Months
            var months = _helper.GetMonths(true);
            foreach (var month in months)
                lstMonths.Items.Add(new ListItem(month.Value, month.Key.ToString()));
            lstMonths.SelectedValue = Request["mm"];

            // Days
            var days = _helper.GetDays();
            foreach (var day in days)
                lstDays.Items.Add(new ListItem(day.Value, day.Key.ToString()));
            lstDays.SelectedValue = Request["dd"];

            // Years
            var years = _helper.GetYears();
            foreach (var year in years)
                lstYears.Items.Add(new ListItem(year.Value, year.Key.ToString()));
            lstYears.SelectedValue = Request["yyyy"];
        }
    }
}