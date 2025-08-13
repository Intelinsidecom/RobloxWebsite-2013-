using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using Roblox.Controls;
using Roblox.Platform.Membership;

namespace Roblox.Thumbs;

[DefaultProperty("User")]
[ToolboxData("<{0}:AvatarImage runat=server></{0}:AvatarImage>")]
[Designer(typeof(ImageDesigner), typeof(IDesigner))]
public abstract class AvatarImage : ThumbnailImage
{
	private IUser _IUser;

	private long _UserId;

	private string _UserName;

	private static readonly ScriptReference _ScriptReference = new ScriptReference("Roblox.Thumbs.AvatarImage.js", "Roblox.Thumbs");

	private static readonly ServiceReference _ServiceReference = new ServiceReference("~/Thumbs/Avatar.asmx");

	[Bindable(true)]
	[Category("Data")]
	public User User
	{
		get
		{
			return User.Get(_UserId);
		}
		set
		{
			InvalidateImageUrl();
			_UserId = value?.ID ?? 0;
			_UserName = value?.Name;
		}
	}

	[Bindable(true)]
	[Category("Data")]
	public IUser IUser
	{
		get
		{
			return _IUser;
		}
		set
		{
			InvalidateImageUrl();
			_UserId = value?.Id ?? 0;
			_UserName = value?.Name;
		}
	}

	[Bindable(true)]
	[Category("Data")]
	public string Username
	{
		get
		{
			return _UserName;
		}
		set
		{
			_UserName = value;
		}
	}

	[Bindable(true)]
	[Category("Data")]
	public long UserID
	{
		get
		{
			return _UserId;
		}
		set
		{
			_UserId = value;
		}
	}

	protected override string ControlClientClass => "Roblox.Thumbs.AvatarImage";

	protected override void AddProperties(ScriptControlDescriptor descriptor)
	{
		descriptor.AddProperty("userID", _UserId);
	}

	protected override ThumbResult GetThumbnailUrl(ImageParameters imageParameters)
	{
		if (_IUser != null)
		{
			return ThumbnailDomainFactories.Avatar.GetThumbnailUrl(_IUser, imageParameters);
		}
		return ThumbnailDomainFactories.Avatar.GetThumbnailUrl(User, imageParameters);
	}

	protected override ScriptReference GetThumbsScriptReference()
	{
		return _ScriptReference;
	}

	protected override ServiceReference GetThumbsServiceReference()
	{
		return _ServiceReference;
	}

	protected override void OnPreRender(EventArgs e)
	{
		if (AlternateText == null && _UserId != 0L)
		{
			AlternateText = _UserName;
			CssClass = string.Join(" ", CssClass, "notranslate");
		}
		base.OnPreRender(e);
	}

	protected override void RenderContents(HtmlTextWriter writer)
	{
		base.RenderContents(writer);
		bool isSmall = Width.Value <= 50.0;
		string bcOverlayUrl = ((_IUser == null) ? ThumbnailDomainFactories.Avatar.GetBuildersClubOverlayUrl(User, isSmall) : ThumbnailDomainFactories.Avatar.GetBuildersClubOverlayUrl(_IUser, isSmall));
		if (!string.IsNullOrEmpty(bcOverlayUrl))
		{
			writer.AddAttribute(HtmlTextWriterAttribute.Src, ResolveUrl(bcOverlayUrl));
			writer.AddAttribute(HtmlTextWriterAttribute.Class, "bcOverlay");
			writer.AddAttribute(HtmlTextWriterAttribute.Align, "left");
			writer.AddStyleAttribute(HtmlTextWriterStyle.Position, "relative");
			writer.AddStyleAttribute(HtmlTextWriterStyle.Top, isSmall ? "-12px" : "-19px");
			writer.RenderBeginTag(HtmlTextWriterTag.Img);
			writer.RenderEndTag();
		}
	}
}
