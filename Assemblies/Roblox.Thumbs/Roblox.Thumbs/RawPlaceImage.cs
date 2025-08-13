using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using Roblox.Controls;

namespace Roblox.Thumbs;

/// <summary>
/// Renders an Asset thumbnail
/// This control is coupled with AssetImage.js and the Asset.cs web service
/// </summary>
[DefaultProperty("Asset")]
[ToolboxData("<{0}:RawPlaceImage runat=server></{0}:RawPlaceImage>")]
[Designer(typeof(ImageDesigner), typeof(IDesigner))]
public abstract class RawPlaceImage : AssetImage
{
	protected override string ControlClientClass => "Roblox.Thumbs.RawPlaceImage";

	protected override ThumbResult GetThumbnailUrl(ImageParameters imageParameters)
	{
		IAsset asset2;
		if (base.AssetVersionID == 0L)
		{
			IAsset asset = base.Asset;
			asset2 = asset;
		}
		else
		{
			IAsset asset = base.AssetVersion;
			asset2 = asset;
		}
		IAsset iAsset = asset2;
		return ThumbnailDomainFactories.Asset.GetPlaceThumbIgnoreAssetMedia(iAsset, imageParameters, OverrideModeration);
	}
}
