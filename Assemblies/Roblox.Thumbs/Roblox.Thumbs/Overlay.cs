namespace Roblox.Thumbs;

public class Overlay
{
	private const string _BuildersClubOverlaySmall = "~/images/AssetIcons/img-overlay-bc-sm.png";

	private const string _BuildersClubOverlayLarge = "~/images/AssetIcons/img-overlay-bc-md.png";

	private const string _TurboBuildersClubOverlaySmall = "~/images/AssetIcons/img-overlay-tbc-sm.png";

	private const string _TurboBuildersClubOverlayLarge = "~/images/AssetIcons/img-overlay-tbc-md.png";

	private const string _OutrageousBuildersClubOverlaySmall = "~/images/AssetIcons/img-overlay-obc-sm.png";

	private const string _OutrageousBuildersClubOverlayLarge = "~/images/AssetIcons/img-overlay-obc-md.png";

	private const string _LimitedUniqueOverlaySmall = "~/images/asseticons/img-overlay-limited-u-sm.png";

	private const string _LimitedUniqueOverlayLarge = "~/images/AssetIcons/img-overlay-limited-u-md.png";

	private const string _LimitedOverlaySmall = "~/images/asseticons/img-overlay-limited-sm.png";

	private const string _LimitedOverlayLarge = "~/images/AssetIcons/img-overlay-limited-md.png";

	private const string _DeadlineOverlay = "~/images/assetIcons/deadline.png";

	private const string _NewOverlay = "~/images/AssetIcons/catalog_new.png";

	private const string _SaleOverlay = "~/images/AssetIcons/sale_green_2.png";

	private const string _IosOverlay = "~/images/AssetIcons/iOSonly.png";

	private const string _MobileOverlay = "~/images/AssetIcons/mobile-only.png";

	private const string _XboxOverlay = "~/images/AssetIcons/xbox-only.png";

	private const string _GooglePlayOverlay = "~/images/AssetIcons/googlePlay-only.png";

	private const string _AmazonOverlay = "~/images/AssetIcons/amazon-only.png";

	public static string GetOverlayUrl(OverlayType type)
	{
		return type switch
		{
			OverlayType.BuildersClubSmall => "~/images/AssetIcons/img-overlay-bc-sm.png", 
			OverlayType.BuildersClubLarge => "~/images/AssetIcons/img-overlay-bc-md.png", 
			OverlayType.TurboBuildersClubSmall => "~/images/AssetIcons/img-overlay-tbc-sm.png", 
			OverlayType.TurboBuildersClubLarge => "~/images/AssetIcons/img-overlay-tbc-md.png", 
			OverlayType.OutrageousBuildersClubSmall => "~/images/AssetIcons/img-overlay-obc-sm.png", 
			OverlayType.OutrageousBuildersClubLarge => "~/images/AssetIcons/img-overlay-obc-md.png", 
			OverlayType.LimitedUniqueSmall => "~/images/asseticons/img-overlay-limited-u-sm.png", 
			OverlayType.LimitedUniqueLarge => "~/images/AssetIcons/img-overlay-limited-u-md.png", 
			OverlayType.LimitedSmall => "~/images/asseticons/img-overlay-limited-sm.png", 
			OverlayType.LimitedLarge => "~/images/AssetIcons/img-overlay-limited-md.png", 
			OverlayType.Deadline => "~/images/assetIcons/deadline.png", 
			OverlayType.New => "~/images/AssetIcons/catalog_new.png", 
			OverlayType.Sale => "~/images/AssetIcons/sale_green_2.png", 
			OverlayType.IOS => "~/images/AssetIcons/iOSonly.png", 
			OverlayType.Xbox => "~/images/AssetIcons/xbox-only.png", 
			OverlayType.Mobile => "~/images/AssetIcons/mobile-only.png", 
			OverlayType.GooglePlay => "~/images/AssetIcons/googlePlay-only.png", 
			OverlayType.Amazon => "~/images/AssetIcons/amazon-only.png", 
			_ => string.Empty, 
		};
	}
}
