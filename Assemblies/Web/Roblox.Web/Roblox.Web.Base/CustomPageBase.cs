using System;
using System.Web.UI;
using Roblox.Web.Properties;

namespace Roblox.Web.Base;

/// <summary>
/// Class: CustomPageBase
/// Type: Abstract
/// Description: The aim of this class is to hook up the standard Page events to event handlers from any aspx page
/// that inherits from this class.
/// </summary>
public abstract class CustomPageBase : Page
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Base.CustomPageBase" /> class.
	/// Hooks events to the page event handlers
	/// </summary>
	public CustomPageBase()
	{
		Page.Load += Page_Load;
		Page.Init += delegate
		{
			if (base.User.Identity.IsAuthenticated)
			{
				base.ViewStateUserKey = base.User.Identity.Name;
			}
		};
		Page.Init += Page_Init;
		Page.Error += Page_Error;
	}

	protected abstract void Page_Load(object sender, EventArgs e);

	protected virtual void Page_Init(object sender, EventArgs e)
	{
	}

	protected virtual void Page_Error(object sender, EventArgs e)
	{
	}

	protected override void Render(HtmlTextWriter writer)
	{
		base.Render(writer);
		if (Settings.Default.PageBaseCacheControlMustRevalidateHeaderEnabled)
		{
			base.Response.Cache.AppendCacheExtension("must-revalidate");
		}
	}
}
