using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Common;
using Roblox.Controls;
using Roblox.Platform.Assets;
using Roblox.Platform.AudioRightsManagement;

namespace Roblox.Thumbs;

/// <summary>
/// Base class for Thumbnail image controls
/// </summary>
public abstract class ThumbnailImage : Roblox.Controls.Image, IScriptControl
{
	private ImageFormat _ImageFormat = ImageFormat.Png;

	private bool? _IsUrlFinal;

	private int _ThumbnailFormatId;

	protected static IRequestProtocolResolver<HttpRequest> ProtocolResolver = new HttpRequestProtocolResolver();

	public TimeSpan PollTime = TimeSpan.FromSeconds(6.0);

	protected abstract string ControlClientClass { get; }

	public abstract ThumbnailDomainFactories ThumbnailDomainFactories { get; }

	public abstract IAudioCopyrightStatusReader AudioCopyrightStatusReader { get; }

	public abstract IAssetFactory AssetFactory { get; }

	public override Unit Height
	{
		get
		{
			if (base.Height != default(Unit))
			{
				return base.Height;
			}
			ThumbnailFormat thumbnailFormat = ThumbnailFormat.Get(_ThumbnailFormatId);
			if (thumbnailFormat != null)
			{
				return thumbnailFormat.Height;
			}
			return base.Height;
		}
		set
		{
			base.Height = value;
		}
	}

	public bool IsUrlFinal
	{
		get
		{
			ComputeImageUrl();
			return _IsUrlFinal.Value;
		}
	}

	[Bindable(true)]
	[Category("Appearance")]
	[DefaultValue("Png")]
	public ImageFormat ImageFormat
	{
		get
		{
			ThumbnailFormat thumbnailFormat = ThumbnailFormat.Get(_ThumbnailFormatId);
			if (thumbnailFormat != null)
			{
				return thumbnailFormat.ImageFormat;
			}
			return _ImageFormat;
		}
		set
		{
			if (_ImageFormat != value)
			{
				_ImageFormat = value;
				InvalidateImageUrl();
			}
		}
	}

	public override string ImageUrl
	{
		get
		{
			ComputeImageUrl();
			return base.ImageUrl;
		}
	}

	[Bindable(true)]
	[Category("Appearance")]
	[DefaultValue(0)]
	public int ThumbnailFormatID
	{
		get
		{
			return _ThumbnailFormatId;
		}
		set
		{
			if (_ThumbnailFormatId != value)
			{
				_ThumbnailFormatId = value;
				InvalidateImageUrl();
			}
		}
	}

	public override Unit Width
	{
		get
		{
			if (base.Width != default(Unit))
			{
				return base.Width;
			}
			ThumbnailFormat thumbnailFormat = ThumbnailFormat.Get(_ThumbnailFormatId);
			if (thumbnailFormat != null)
			{
				return thumbnailFormat.Width;
			}
			return base.Width;
		}
		set
		{
			base.Width = value;
		}
	}

	public override bool SupportsAlphaChannel => ImageFormat == ImageFormat.Png;

	private void ComputeImageUrl()
	{
		if (!base.DesignMode && !_IsUrlFinal.HasValue)
		{
			ThumbnailFormat thumbnailFormat = ThumbnailFormat.Get(_ThumbnailFormatId);
			ImageParameters imageParameters = ((thumbnailFormat == null) ? new ImageParameters(Width, Height, _ImageFormat, _ThumbnailFormatId) : new ImageParameters(thumbnailFormat.Width, thumbnailFormat.Height, _ImageFormat, _ThumbnailFormatId));
			ThumbResult thumbResult = GetThumbnailUrl(imageParameters);
			ImageUrl = thumbResult.GetUrl(ProtocolResolver.IsRequestSecure(Context.Request));
			_IsUrlFinal = thumbResult.final;
		}
	}

	protected abstract void AddProperties(ScriptControlDescriptor descriptor);

	protected abstract ThumbResult GetThumbnailUrl(ImageParameters parameters);

	protected abstract ScriptReference GetThumbsScriptReference();

	protected abstract ServiceReference GetThumbsServiceReference();

	protected override void OnLoad(EventArgs e)
	{
		object isUrlFinal = ViewState["IsUrlFinal"];
		if (isUrlFinal != null)
		{
			_IsUrlFinal = (bool)isUrlFinal;
		}
		base.OnLoad(e);
	}

	protected override void OnPreRender(EventArgs e)
	{
		ViewState["IsUrlFinal"] = IsUrlFinal;
		if (!base.DesignMode && !IsUrlFinal)
		{
			ScriptManager obj = ScriptManager.GetCurrent(Page) ?? throw new HttpException("A ScriptManager control must exist on the current page.");
			obj.Services.Add(GetThumbsServiceReference());
			obj.RegisterScriptControl(this);
			string script = string.Format(CultureInfo.InvariantCulture, "{0}.updateUrl('{1}');", ControlClientClass, ClientID);
			script = string.Format(CultureInfo.InvariantCulture, ";(function() {{var fn = function() {{{0}Sys.Application.remove_load(fn);}};Sys.Application.add_load(fn);}})();", script);
			ScriptManager.RegisterStartupScript(this, GetType(), "UpdateUrl" + ClientID, script, addScriptTags: true);
		}
		base.OnPreRender(e);
	}

	protected override void Render(HtmlTextWriter writer)
	{
		if (!base.DesignMode && !IsUrlFinal)
		{
			ScriptManager.GetCurrent(Page).RegisterScriptDescriptors(this);
		}
		base.Render(writer);
	}

	public void InvalidateImageUrl()
	{
		_IsUrlFinal = null;
	}

	public IEnumerable<ScriptDescriptor> GetScriptDescriptors()
	{
		ScriptControlDescriptor scriptControlDescriptor = new ScriptControlDescriptor(ControlClientClass, ClientID);
		AddProperties(scriptControlDescriptor);
		scriptControlDescriptor.AddProperty("fileExtension", _ImageFormat.ToString());
		scriptControlDescriptor.AddProperty("spinnerUrl", ResolveUrl("~/Thumbs/ProgressIndicator.gif"));
		scriptControlDescriptor.AddProperty("thumbnailFormatID", _ThumbnailFormatId);
		scriptControlDescriptor.AddProperty("pollTime", PollTime.TotalMilliseconds.ToString("F0"));
		yield return scriptControlDescriptor;
	}

	public IEnumerable<ScriptReference> GetScriptReferences()
	{
		yield return new ScriptReference("Roblox.Thumbs.Image.js", "Roblox.Thumbs");
		yield return GetThumbsScriptReference();
	}
}
