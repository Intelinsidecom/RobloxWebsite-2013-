namespace Roblox.Platform.Outfits;

internal interface ISettings
{
	decimal ScaleHeightDefault { get; }

	decimal ScaleWidthDefault { get; }

	decimal ScaleHeadDefault { get; }

	decimal ScaleProportionDefault { get; }

	decimal ScaleProportionMin { get; }

	decimal ScaleProportionMax { get; }

	decimal ScaleBodyTypeDefault { get; }

	decimal ScaleBodyTypeMin { get; }

	decimal ScaleBodyTypeMax { get; }

	bool UseThumbnailKeyV2Format { get; }
}
