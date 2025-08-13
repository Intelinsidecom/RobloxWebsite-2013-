using System.IO;
using System.Web.UI;
using System.Web.UI.Design;
using System.Web.UI.WebControls;

namespace Roblox.Controls;

/// <summary>
///
/// </summary>
public class ImageDesigner : ControlDesigner
{
	public override string GetDesignTimeHtml()
	{
		Image cmdButton = (Image)base.Component;
		using StringWriter sw = new StringWriter();
		System.Web.UI.WebControls.Image placeholderImage = new System.Web.UI.WebControls.Image();
		placeholderImage.AlternateText = cmdButton.AlternateText;
		placeholderImage.ToolTip = cmdButton.ToolTip;
		if (cmdButton.Width.Value != 0.0)
		{
			placeholderImage.Width = cmdButton.Width;
		}
		if (cmdButton.Height.Value != 0.0)
		{
			placeholderImage.Height = cmdButton.Height;
		}
		HtmlTextWriter tw = new HtmlTextWriter(sw);
		placeholderImage.RenderControl(tw);
		return sw.ToString();
	}
}
