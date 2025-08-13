using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Roblox.Controls;

/// <summary>
/// A container control that encapsulates a Roblox panel using our
/// CSS.  See http://www.angrylittledog.com/roblox/demo/index.html
/// </summary>
[ParseChildren(true)]
[PersistChildren(false)]
[Designer(typeof(PanelDesigner))]
[ToolboxData("<{0}:Panel runat=server></{0}:Panel>")]
public class Panel : CompositeControl
{
	public class HeaderTemplateContainer : Control, INamingContainer
	{
		private Panel parent;

		public string Text => parent.Caption;

		public HeaderTemplateContainer(Panel parent)
		{
			this.parent = parent;
		}
	}

	public class ContentTemplateContainer : Control, INamingContainer
	{
	}

	public class FooterTemplateContainer : Control, INamingContainer
	{
	}

	private string title;

	private ITemplate headerTemplate;

	private ITemplate contentTemplate;

	private ITemplate footerTemplate;

	protected override HtmlTextWriterTag TagKey => HtmlTextWriterTag.Div;

	[TemplateContainer(typeof(HeaderTemplateContainer))]
	[PersistenceMode(PersistenceMode.InnerProperty)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[TemplateInstance(TemplateInstance.Single)]
	[Browsable(false)]
	public ITemplate Header
	{
		get
		{
			return headerTemplate;
		}
		set
		{
			headerTemplate = value;
		}
	}

	[TemplateContainer(typeof(ContentTemplateContainer))]
	[PersistenceMode(PersistenceMode.InnerProperty)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[TemplateInstance(TemplateInstance.Single)]
	[Browsable(false)]
	public ITemplate Content
	{
		get
		{
			return contentTemplate;
		}
		set
		{
			contentTemplate = value;
		}
	}

	[TemplateContainer(typeof(FooterTemplateContainer))]
	[PersistenceMode(PersistenceMode.InnerProperty)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[TemplateInstance(TemplateInstance.Single)]
	[Browsable(false)]
	public ITemplate Footer
	{
		get
		{
			return footerTemplate;
		}
		set
		{
			footerTemplate = value;
		}
	}

	[Category("Appearance")]
	public string Caption
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	protected override void OnDataBinding(EventArgs e)
	{
		EnsureChildControls();
		base.OnDataBinding(e);
	}

	private HtmlGenericControl AddDiv(Control parent, string classes)
	{
		HtmlGenericControl div = new HtmlGenericControl("div");
		div.Attributes["class"] = classes;
		parent.Controls.Add(div);
		return div;
	}

	protected override void OnInit(EventArgs e)
	{
		EnsureChildControls();
		base.OnInit(e);
	}

	protected override void CreateChildControls()
	{
		HtmlGenericControl panel_header = AddDiv(this, "panel_header");
		HtmlGenericControl panel_header_left = AddDiv(panel_header, "panel_header_left");
		HtmlGenericControl panel_header_right = AddDiv(panel_header_left, "panel_header_right");
		HtmlGenericControl panel_header_content = AddDiv(panel_header_right, "panel_header_content");
		if (headerTemplate != null)
		{
			Control container3 = new HeaderTemplateContainer(this);
			headerTemplate.InstantiateIn(container3);
			panel_header_content.Controls.Add(container3);
		}
		else if (!string.IsNullOrEmpty(Caption))
		{
			HtmlGenericControl p = new HtmlGenericControl("p");
			p.InnerText = Caption;
			panel_header_content.Controls.Add(p);
		}
		HtmlGenericControl panel_content = AddDiv(this, "panel_content");
		HtmlGenericControl panel_content_body = AddDiv(panel_content, "panel_content_body");
		AddDiv(panel_content_body, "spacer");
		if (contentTemplate != null)
		{
			Control container2 = new ContentTemplateContainer();
			contentTemplate.InstantiateIn(container2);
			panel_content_body.Controls.Add(container2);
			AddDiv(panel_content_body, "spacer");
		}
		HtmlGenericControl panel_footer = AddDiv(this, "panel_footer");
		HtmlGenericControl panel_footer_left = AddDiv(panel_footer, "panel_footer_left");
		HtmlGenericControl panel_footer_right = AddDiv(panel_footer_left, "panel_footer_right");
		HtmlGenericControl panel_footer_main = AddDiv(panel_footer_right, "panel_footer_main");
		if (footerTemplate != null)
		{
			Control container = new FooterTemplateContainer();
			footerTemplate.InstantiateIn(container);
			panel_footer_main.Controls.Add(container);
		}
	}
}
