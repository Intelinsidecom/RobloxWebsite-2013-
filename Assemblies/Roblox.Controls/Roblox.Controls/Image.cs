using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Globalization;
using System.Threading;
using System.Timers;
using System.Web;
using System.Web.UI;
using System.Web.UI.Design;
using System.Web.UI.WebControls;
using Roblox.Analytics;
using Roblox.Common;
using Roblox.Controls.Properties;

namespace Roblox.Controls;

/// <summary>
/// This clever little Image class manages to render PNG files with a proper Alpha
///
/// It also has a NavigateUrl property, so it can act like a HyperLink!
///
/// TODO: Currently this only works if you are displaying an image at its original size. See below
/// </summary>
[DefaultProperty("ImageUrl")]
[ToolboxData("<{0}:Image runat=server></{0}:Image>")]
[Designer(typeof(ImageDesigner), typeof(IDesigner))]
public class Image : WebControl, IPostBackEventHandler
{
	private static int ErrorMonitorCount;

	private bool supportsAlphaChannel = true;

	private string alt;

	private string imageUrl;

	private string navigateUrl;

	private string commandArgument;

	private string commandName = "";

	public string OnClientClick;

	[Bindable(true)]
	[Category("Appearance")]
	[DefaultValue("")]
	public virtual bool SupportsAlphaChannel
	{
		get
		{
			return supportsAlphaChannel;
		}
		set
		{
			supportsAlphaChannel = value;
		}
	}

	[Bindable(true)]
	[Category("Appearance")]
	[DefaultValue("")]
	public virtual string AlternateText
	{
		get
		{
			return alt;
		}
		set
		{
			alt = value;
		}
	}

	[Bindable(true)]
	[Category("Appearance")]
	[DefaultValue("")]
	[Editor(typeof(ImageUrlEditor), typeof(UITypeEditor))]
	public virtual string ImageUrl
	{
		get
		{
			return imageUrl;
		}
		set
		{
			imageUrl = value;
		}
	}

	[Bindable(true)]
	[Category("Behavior")]
	public string CommandArgument
	{
		get
		{
			return commandArgument;
		}
		set
		{
			commandArgument = value;
		}
	}

	[Bindable(true)]
	[Category("Behavior")]
	public virtual string NavigateUrl
	{
		get
		{
			return navigateUrl;
		}
		set
		{
			navigateUrl = value;
		}
	}

	[Bindable(true)]
	[Category("Behavior")]
	[DefaultValue("")]
	public string CommandName
	{
		get
		{
			return commandName;
		}
		set
		{
			commandName = value;
		}
	}

	public event EventHandler Click;

	public event EventHandler Command;

	public Image()
		: base(HtmlTextWriterTag.A)
	{
	}

	static Image()
	{
		if (Settings.Default.LogThumbnailErrors)
		{
			System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromMinutes(5.0).TotalMilliseconds);
			timer.Elapsed += timer_Elapsed;
			timer.Start();
		}
	}

	private static void timer_Elapsed(object sender, ElapsedEventArgs e)
	{
		int count = Interlocked.Exchange(ref ErrorMonitorCount, 0);
		Helper.LogMeasurement("HtmlImageRender:Total", DateTime.Now, null, null, null, new KeyValuePair<string, double>[1]
		{
			new KeyValuePair<string, double>("rendered", count)
		});
	}

	private string ResolveImageUrl()
	{
		string url = ((ImageUrl != "") ? ImageUrl : base.Attributes["imageUrl"]);
		if (url != null && url != "")
		{
			return ResolveUrl(url);
		}
		return "";
	}

	protected virtual void OnClick(EventArgs e)
	{
		if (CommandName != "")
		{
			RaiseBubbleEvent(this, new CommandEventArgs(CommandName, CommandArgument));
		}
		if (this.Click != null)
		{
			this.Click(this, e);
		}
	}

	protected virtual void OnCommand(CommandEventArgs e)
	{
		if (CommandName != "")
		{
			RaiseBubbleEvent(this, new CommandEventArgs(CommandName, CommandArgument));
		}
		if (this.Command != null)
		{
			this.Command(this, e);
		}
	}

	public void RaisePostBackEvent(string eventArgument)
	{
		OnClick(new EventArgs());
	}

	protected override void OnPreRender(EventArgs e)
	{
		ScriptManager sm = ScriptManager.GetCurrent(Page);
		if (sm == null)
		{
			throw new HttpException("A ScriptManager control must exist on the current page.");
		}
		sm.Scripts.Add(new ScriptReference("Roblox.Controls.Image.min.js", "Roblox.Controls"));
		if (Settings.Default.LogThumbnailErrors)
		{
			string script = string.Format(CultureInfo.InvariantCulture, "Roblox.Controls.Image.ErrorUrl = \"{0}\";", Web.ResolveWithDomain(Context, "~/Analytics/BadHtmlImage.ashx"));
			ScriptManager.RegisterStartupScript(Page, typeof(Image), "Init", script, addScriptTags: true);
		}
		base.OnPreRender(e);
	}

	protected override void Render(HtmlTextWriter writer)
	{
		if (!string.IsNullOrEmpty(AlternateText))
		{
			base.Attributes.Add("title", AlternateText);
		}
		if (!string.IsNullOrEmpty(CssClass))
		{
			base.Attributes.Add("class", CssClass);
		}
		if (NavigateUrl != null)
		{
			string href = ResolveUrl(NavigateUrl);
			base.Attributes.Add("href", href);
		}
		else if (Enabled)
		{
			if (!string.IsNullOrEmpty(OnClientClick))
			{
				string script = "var fn = function() { " + OnClientClick + " }; if (fn()) " + Page.ClientScript.GetPostBackEventReference(this, null) + "; else return false;";
				base.Attributes.Add("onclick", script);
			}
			else
			{
				base.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(this, null));
			}
		}
		else
		{
			base.Attributes.Add("onclick", "return false");
		}
		if (Enabled)
		{
			base.Style.Add("cursor", "pointer");
		}
		base.Render(writer);
	}

	protected override void RenderContents(HtmlTextWriter writer)
	{
		writer.AddAttribute(HtmlTextWriterAttribute.Src, ResolveImageUrl(), fEncode: false);
		writer.AddAttribute("height", Height.Value.ToString());
		writer.AddAttribute("width", Width.Value.ToString());
		writer.AddAttribute("border", "0");
		if (Settings.Default.LogThumbnailErrors)
		{
			writer.AddAttribute("onerror", "return Roblox.Controls.Image.OnError(this)");
			Interlocked.Increment(ref ErrorMonitorCount);
		}
		if (!string.IsNullOrEmpty(AlternateText))
		{
			writer.AddAttribute("alt", AlternateText);
		}
		if (!string.IsNullOrEmpty(CssClass))
		{
			writer.AddAttribute("class", CssClass);
		}
		writer.RenderBeginTag(HtmlTextWriterTag.Img);
		writer.RenderEndTag();
		base.RenderContents(writer);
	}

	protected override void LoadViewState(object savedState)
	{
		base.LoadViewState(savedState);
		imageUrl = ViewState["ImageUrl"] as string;
		commandName = ViewState["CommandName"] as string;
		commandArgument = ViewState["CommandArgument"] as string;
	}

	protected override object SaveViewState()
	{
		ViewState["ImageUrl"] = imageUrl;
		ViewState["CommandName"] = commandName;
		ViewState["CommandArgument"] = commandArgument;
		return base.SaveViewState();
	}
}
