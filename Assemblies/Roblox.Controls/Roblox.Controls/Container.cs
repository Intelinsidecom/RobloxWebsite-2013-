using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Controls;

/// <summary>
/// A control that renders its children (if Visible) but does not inject any other markup onto the page.
/// Compare to Panel, which renders a div or span around the children
/// http://msdn2.microsoft.com/en-us/library/system.web.ui.design.containercontroldesigner.aspx
/// </summary>
[Designer(typeof(ContainerDesigner))]
[ParseChildren(false)]
public class Container : CompositeControl
{
	public override void RenderControl(HtmlTextWriter writer)
	{
		if (Visible)
		{
			RenderContents(writer);
		}
	}
}
