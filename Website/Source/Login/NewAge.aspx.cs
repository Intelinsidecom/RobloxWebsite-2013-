using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using Roblox.Website.WebCode;

namespace Roblox.Website.Login
{
    public partial class NewAge : System.Web.UI.Page
    {
        private SignupHelper Helper;

        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Response.Redirect("~/Login/Signup.aspx", true);

            if (Request.IsAuthenticated)
                Response.Redirect("~/", true);

            Helper = new SignupHelper(CultureInfo.CurrentUICulture);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                HandlePostBack();

            FillDropDowns();
            DataBind();
        }

        protected void HandlePostBack()
        {
            RadioButton genderRadioBtn = SelectGenderPane.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            Response.Redirect($"/account/signupredir?month={lstMonths.SelectedValue}&day={lstDays.SelectedValue}&year={lstYears.SelectedValue}&gender={genderRadioBtn.ID}", true);
        }

        protected void FillDropDowns()
        {
            // Months
            var months = Helper.GetMonths();
            foreach (var month in months)
                lstMonths.Items.Add(new ListItem(month.Value, month.Key.ToString()));

            // Days
            var days = Helper.GetDays();
            foreach (var day in days)
                lstDays.Items.Add(new ListItem(day.Value, day.Key.ToString()));

            // Years
            var years = Helper.GetYears();
            foreach (var year in years)
                lstYears.Items.Add(new ListItem(year.Value, year.Key.ToString()));
        }
    }
}