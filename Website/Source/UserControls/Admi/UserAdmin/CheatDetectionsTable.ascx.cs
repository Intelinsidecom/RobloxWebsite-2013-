using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.UserControls.Admi.UserAdmin
{
    public partial class CheatDetectionsTable : System.Web.UI.UserControl
    {
        public int UserID { get; set; }
        public bool RenderHeader { get; set; } = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (RenderHeader)
                CheatDetectionGridView.RowCreated += CheatDetectionGridView_RowCreated;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {

            CheatDetectionGridView.DataSource = new string[] { };
            CheatDetectionGridView.DataBind();
        }

        protected void CheatDetectionGridView_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                GridView HeaderGrid = (GridView)sender;
                GridViewRow HeaderGridRow = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell HeaderCell = new TableCell();
                HeaderCell.Text = "Cheat<br />Detections";
                HeaderCell.ColumnSpan = 1;
                HeaderCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#6E99C6");
                HeaderCell.ForeColor = System.Drawing.Color.White;
                HeaderCell.Height = 42;
                HeaderCell.Width = 135;
                HeaderCell.HorizontalAlign = HorizontalAlign.Center;
                HeaderGridRow.Cells.Add(HeaderCell);

                ((GridView)sender).Controls[0].Controls.AddAt(0, HeaderGridRow);
            }
        }
    }
}