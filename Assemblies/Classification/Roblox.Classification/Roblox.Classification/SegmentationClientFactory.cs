using Roblox.Classification.Properties;
using Roblox.Segmentation.Client;

namespace Roblox.Classification;

internal static class SegmentationClientFactory
{
	private static readonly SegmentationClient _Client = new SegmentationClient(() => Settings.Default.ApiKey);

	public static SegmentationClient GetSegmentationClient()
	{
		return _Client;
	}
}
