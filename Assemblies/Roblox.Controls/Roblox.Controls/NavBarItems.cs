using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Controls;

/// <summary>
/// Adds navigation bar items as driven by entries in Web.sitemap
/// (that have navbaritem="true").
/// </summary>
[ToolboxData("<{0}:NavBarItems runat=server></{0}:NavBarItems>")]
public class NavBarItems : WebControl
{
	/// <summary>
	/// A hyperlink for use within the navigation bar - it adds on a CSS class, as appropriate,
	/// to highlight the navigation link under which the current page falls.
	/// </summary>
	private sealed class NavHyperLink : HyperLink
	{
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (FallsUnderThisNavLink(SiteMap.CurrentNode))
			{
				CssClass += " nav_on";
			}
		}

		/// <summary>
		/// Walk up the site map from node, looking for a node that matches
		/// this hyperlink's NavigateUrl.
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		private bool FallsUnderThisNavLink(SiteMapNode node)
		{
			while (node != null)
			{
				Uri nodeUri = null;
				Uri hyperlinkUri = null;
				if (Uri.TryCreate(ResolveUrl(node.Url), UriKind.RelativeOrAbsolute, out nodeUri) && Uri.TryCreate(ResolveUrl(base.NavigateUrl), UriKind.RelativeOrAbsolute, out hyperlinkUri) && nodeUri.Equals(hyperlinkUri))
				{
					return true;
				}
				node = node.ParentNode;
			}
			return false;
		}
	}

	protected override void CreateChildControls()
	{
		base.CreateChildControls();
		AddNavButtonDivider();
		AddNavBarItemsForChildNodes(SiteMap.RootNode, bDividerSeparated: true);
	}

	private void AddNavBarItemsForChildNodes(SiteMapNode node, bool bDividerSeparated)
	{
		foreach (SiteMapNode childNode in node.ChildNodes)
		{
			bool bNavBarItem = false;
			if (bool.TryParse(childNode["NavBarItem"], out bNavBarItem) && bNavBarItem)
			{
				AddNavBarItem(childNode);
				if (bDividerSeparated)
				{
					AddNavButtonDivider();
				}
			}
			if (!bNavBarItem)
			{
				bool bNavBarGroup = false;
				if (bool.TryParse(childNode["NavBarGroup"], out bNavBarGroup) && bNavBarGroup)
				{
					AddNavBarItemsForChildNodes(childNode, bDividerSeparated: false);
					AddNavButtonDivider();
				}
			}
		}
	}

	private void AddNavBarItem(SiteMapNode node)
	{
		NavHyperLink navHyperlink = new NavHyperLink();
		navHyperlink.NavigateUrl = node.Url;
		navHyperlink.Text = node.Title;
		navHyperlink.ToolTip = node.Description;
		navHyperlink.CssClass = node["CssClass"];
		navHyperlink.Target = node["Target"];
		navHyperlink.ImageUrl = node["ImageUrl"];
		Controls.Add(navHyperlink);
	}

	private void AddNavButtonDivider()
	{
		System.Web.UI.WebControls.Panel aspPanelDivider = new System.Web.UI.WebControls.Panel();
		aspPanelDivider.CssClass = "nav_button_div";
		Controls.Add(aspPanelDivider);
	}
}
