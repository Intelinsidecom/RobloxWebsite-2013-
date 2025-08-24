using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web;
using System.Web.UI;
using Roblox.Controls;
using Roblox.Platform.Assets;
using Roblox.Thumbs.Properties;

namespace Roblox.Thumbs;

/// <summary>
/// Renders an Asset thumbnail
/// This control is coupled with AssetImage.js and the Asset.cs web service
/// </summary>
[DefaultProperty("Asset")]
[ToolboxData("<{0}:AssetImage runat=server></{0}:AssetImage>")]
[Designer(typeof(ImageDesigner), typeof(IDesigner))]
public abstract class AssetImage : ThumbnailImage
{
	private long _AssetId;

	private long _AssetVersionId;

	private long _SnapshotAssetHashId;

	[Bindable(true)]
	[Category("Data")]
	public bool IsPixelated;

	[Bindable(true)]
	[Category("Data")]
	public bool OverrideModeration;

	private static readonly ScriptReference _ScriptReference = new ScriptReference("Roblox.Thumbs.AssetImage.js", "Roblox.Thumbs");

	private static readonly ServiceReference _ServiceReference = new ServiceReference("~/Thumbs/Asset.asmx");

	[Bindable(true)]
	[Category("Data")]
	public Roblox.Asset Asset
	{
		get
		{
			return Roblox.Asset.Get(_AssetId);
		}
		set
		{
			_AssetId = value?.ID ?? 0;
		}
	}

	[Bindable(true)]
	[Category("Data")]
	public long AssetID
	{
		get
		{
			return _AssetId;
		}
		set
		{
			if (value != _AssetId)
			{
				_AssetId = value;
				InvalidateImageUrl();
			}
		}
	}

	public long SnapshotAssetHashID
	{
		get
		{
			return _SnapshotAssetHashId;
		}
		set
		{
			_SnapshotAssetHashId = value;
		}
	}

	public bool ShouldShowSnapshotThumbnail { get; set; }

	[Bindable(true)]
	[Category("Data")]
	public AssetVersion AssetVersion
	{
		get
		{
			return AssetVersion.Get(_AssetVersionId);
		}
		set
		{
			if (value == null)
			{
				_AssetVersionId = 0L;
				return;
			}
			_AssetVersionId = value.ID;
			_AssetId = value.AssetID;
		}
	}

	[Bindable(true)]
	[Category("Data")]
	public long AssetVersionID
	{
		get
		{
			return _AssetVersionId;
		}
		set
		{
			if (value != _AssetVersionId)
			{
				_AssetVersionId = value;
				AssetVersion assetVersion = AssetVersion.Get(_AssetVersionId);
				_AssetId = assetVersion.AssetID;
				InvalidateImageUrl();
			}
		}
	}

	protected override string ControlClientClass => "Roblox.Thumbs.AssetImage";

	public override bool SupportsAlphaChannel
	{
		get
		{
			if (base.SupportsAlphaChannel && _AssetId != 0L)
			{
				return Asset.AssetTypeID != AssetType.PlaceID;
			}
			return false;
		}
	}

	protected override void AddProperties(ScriptControlDescriptor descriptor)
	{
		descriptor.AddProperty("assetID", _AssetId);
		descriptor.AddProperty("assetVersionID", _AssetVersionId);
		descriptor.AddProperty("ov", OverrideModeration);
	}

	protected override ThumbResult GetThumbnailUrl(ImageParameters imageParameters)
	{
		if (ShouldShowSnapshotThumbnail)
		{
			return ThumbnailDomainFactories.Asset.GetThumbnailUrlByAssetHashIdForSnapshots(SnapshotAssetHashID, imageParameters);
		}
		IAsset asset2;
		if (_AssetVersionId == 0L)
		{
			IAsset asset = Asset;
			asset2 = asset;
		}
		else
		{
			IAsset asset = AssetVersion;
			asset2 = asset;
		}
		IAsset iAsset = asset2;
		if (IsPixelated)
		{
			string url;
			if (iAsset is AssetVersion)
			{
				url = $"~/Thumbs/Pixelated.ashx?versionid={_AssetVersionId}&{imageParameters}";
			}
			else
			{
				url = $"~/Thumbs/Pixelated.ashx?id={_AssetId}&{imageParameters}";
			}
			ThumbResult thumbnailUrl = ThumbnailDomainFactories.Asset.GetThumbnailUrl(iAsset, imageParameters, OverrideModeration);
			thumbnailUrl.GetUrl = (bool isSecureConnection) => ResolveUrl(url);
			return thumbnailUrl;
		}
		return ThumbnailDomainFactories.Asset.GetThumbnailUrl(iAsset, imageParameters, OverrideModeration);
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
		if (AlternateText == null && _AssetId != 0L)
		{
			AlternateText = Asset.Name;
			CssClass = string.Join(" ", CssClass, "notranslate");
		}
		if (Settings.Default.AudioPlaybackEnabled && Asset != null && Asset.AssetTypeID == AssetType.AudioID && (OverrideModeration || Asset.IsApproved))
		{
			ScriptManager.RegisterStartupScript(this, GetType(), "InitMediaPlayer", ";$(function() { Roblox.Thumbs.AssetImage.InitMediaPlayer(); });", addScriptTags: true);
		}
		base.OnPreRender(e);
	}

	protected override void Render(HtmlTextWriter writer)
	{
		base.Render(writer);
		if ((Settings.Default.AudioPlaybackEnabled || OverrideModeration) && Asset != null && Asset.AssetTypeID == AssetType.AudioID && (OverrideModeration || Asset.IsApproved))
		{
			Roblox.Platform.Assets.IAsset platformAsset = AssetFactory.GetAsset(Asset.ID);
			if (platformAsset != null && !AudioCopyrightStatusReader.IsAudioCopyrightProtected(platformAsset))
			{
				writer.AddAttribute("class", "MediaPlayerControls");
				writer.AddStyleAttribute(HtmlTextWriterStyle.Top, "-27px");
				writer.AddStyleAttribute(HtmlTextWriterStyle.Left, Convert.ToInt32(Width.Value) - 27 + "px");
				writer.RenderBeginTag(HtmlTextWriterTag.Div);
				writer.AddAttribute("class", "MediaPlayerIcon Play");
				string url = FilesManager.Singleton.GetUri(Asset.Hash, HttpContext.Current.Request).AbsoluteUri;
				writer.AddAttribute("data-mediathumb-url", url);
				writer.RenderBeginTag(HtmlTextWriterTag.Div);
				writer.RenderEndTag();
				writer.RenderEndTag();
			}
		}
	}
}
