using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Roblox.Website.Login
{
    public partial class NewAge : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Response.Redirect("~/Login/Signup.aspx", true);

            if (Request.IsAuthenticated)
                Response.Redirect("~/", true);

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
            
        }
    }
}