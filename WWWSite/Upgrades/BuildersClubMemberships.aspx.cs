using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Web.StaticContent;

namespace Roblox.Website.Upgrades
{
    public partial class BuildersClubMemberships : System.Web.UI.Page
    {
        // TODO: These should be put into their own project at some point
        public enum BCRenewalTypes
        {
            OneMonth,
            SixMonths,
            TwelveMonths,
            Lifetime
        }
        public enum BCTypes
        {
            Regular,
            Turbo,
            Outrageous
        }
        public enum BCTypesShort
        {
            BC,
            TBC,
            OBC
        }

        protected BCRenewalTypes[] bcRenewalTypes = {
            BCRenewalTypes.OneMonth,
            BCRenewalTypes.SixMonths,
            BCRenewalTypes.TwelveMonths,
            BCRenewalTypes.Lifetime
        };
        protected string[] bcRenewalTypesShort =
        {
            "monthly",
            "6",
            "12",
            "life"
        };
        protected BCTypes[] bcTypes =
        {
            BCTypes.Regular,
            BCTypes.Turbo,
            BCTypes.Outrageous
        };
        protected BCTypesShort[] bcTypesShort =
        {
            BCTypesShort.BC,
            BCTypesShort.TBC,
            BCTypesShort.OBC
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            // This was one of the first pages ever added. ewww


            /*System.Web.UI.HtmlControls.HtmlGenericControl MembershipOptions =
            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
            MembershipOptions.ID = "MembershipOptions";
            MembershipOptions.Style.Add(HtmlTextWriterStyle.MarginBottom, "18px");
            MembershipOptions.Style.Add(HtmlTextWriterStyle.Position, "Relative");
            MembershipOptions.Style.Add(HtmlTextWriterStyle.Direction, "left");
            MembershipPanelStyle2.Controls.Add(MembershipOptions);*/
            //margin-bottom: 18px; position: relative; float: left
        }

        protected LinkButton GetBCImageLinkButton(BCRenewalTypes bcRenewalType, string bcRenewalTypeShort, BCTypesShort bcTypeShort)
        {
            // GetBCImageLinkButton(bcRenewalTypes[0], bcRenewalTypesShort[0], bcTypesShort[0])
            var imageLinkId = bcTypeShort.ToString() + bcRenewalType.ToString() + "ImageLink";
            var linkButtonId = imageLinkId + "Button";
            LinkButton lb = new LinkButton();
            lb.ID = imageLinkId;
            Panel p = new Panel();
            p.ID = linkButtonId + "ImageLink";
            p.CssClass = "upgrades_enabled " + bcTypeShort + bcRenewalTypeShort;
            lb.Controls.Add(p);
            return lb;

            //var bcType = bcTypes[0].ToString();
            //var bcTypeShort = bcTypesShort[0].ToString();
            /*for (int i = 0; i < bcRenewalTypes.Count(); i++)
            {*/
            //var bcRenewalType = bcRenewalTypes[i].ToString();
            //var bcRenewalTypeShort = bcRenewalTypesShort[i];
            /*var imageLinkId = bcTypeShort + bcRenewalType + "ImageLink";
            var linkButtonId = imageLinkId + "Button";
            var classVar = "upgrades_enabled " + bcTypeShort + bcRenewalTypeShort;*/
            /*
             * <asp:LinkButton ID=<%: linkButtonId%> runat="server"><div ID=<%: imageLinkId%> class=<%: classVar%> runat="server">
                                        </div></asp:LinkButton>
            */
            //}
        }
    }
}