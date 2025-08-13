using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Controls;

/// <summary>
/// A breadcrumb that only shows up when you're at a level that is deeper than 
/// the level of the navigation items.
/// </summary>
[ToolboxData("<{0}:Breadcrumb runat=server></{0}:Breadcrumb>")]
public class Breadcrumb : WebControl
{
	protected override void CreateChildControls()
	{
		int nAncestryLevel = GetAncestryLevel(SiteMap.CurrentNode);
		if (nAncestryLevel > 2)
		{
			SiteMapPath smp = new SiteMapPath();
			smp.PathSeparator = " / ";
			smp.ParentLevelsDisplayed = nAncestryLevel - 2;
			Controls.Add(smp);
		}
	}

	/// <summary>
	/// Gets the ancestry level of a node - its level on a tree with root being 1. 
	///
	/// If node is null, ancestry level is 0.
	/// If node is root, ancestry level is 1.
	/// If node is child of root, ancestry level is 2.
	/// If node is grandchild of root, ancestry level is 3.
	/// Etc.
	/// </summary>
	/// <param name="node"></param>
	/// <returns></returns>
	private static int GetAncestryLevel(SiteMapNode node)
	{
		int nLevel = 0;
		while (node != null)
		{
			nLevel++;
			node = node.ParentNode;
		}
		return nLevel;
	}
}
