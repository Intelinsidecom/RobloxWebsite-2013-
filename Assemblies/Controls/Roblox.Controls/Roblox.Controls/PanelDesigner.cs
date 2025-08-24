using System.ComponentModel;
using System.Web.UI.Design;
using System.Web.UI.Design.WebControls;

namespace Roblox.Controls;

public class PanelDesigner : CompositeControlDesigner
{
	private TemplateGroupCollection col;

	private Panel panel;

	public override TemplateGroupCollection TemplateGroups
	{
		get
		{
			if (col == null)
			{
				col = base.TemplateGroups;
				TemplateGroup tempGroup = new TemplateGroup("Panel Templates");
				tempGroup.AddTemplateDefinition(new TemplateDefinition(this, "Content", panel, "Content", serverControlsOnly: false));
				tempGroup.AddTemplateDefinition(new TemplateDefinition(this, "Header", panel, "Header", serverControlsOnly: false));
				tempGroup.AddTemplateDefinition(new TemplateDefinition(this, "Footer", panel, "Footer", serverControlsOnly: false));
				col.Add(tempGroup);
			}
			return col;
		}
	}

	public override bool AllowResize => false;

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		panel = (Panel)component;
		SetViewFlags(ViewFlags.TemplateEditing, setFlag: true);
	}

	public override string GetDesignTimeHtml()
	{
		panel.DataBind();
		return base.GetDesignTimeHtml();
	}
}
