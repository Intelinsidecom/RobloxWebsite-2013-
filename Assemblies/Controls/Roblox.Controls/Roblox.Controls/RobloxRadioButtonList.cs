using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Controls;

[DefaultProperty("Text")]
[ToolboxData("<{0}:RobloxRadioButtonList runat=server></{0}:RobloxRadioButtonList>")]
public class RobloxRadioButtonList : RadioButtonList
{
	protected override void RenderItem(ListItemType itemType, int repeatIndex, RepeatInfo repeatInfo, HtmlTextWriter writer)
	{
		writer.Write("<div style=\"float:left\">");
		base.RenderItem(itemType, repeatIndex, repeatInfo, writer);
		writer.Write("</div>");
	}
}
