namespace Roblox.Platform.EventStream.WebEvents;

public class GameDetailReferralEventArgs : WebEventArgs
{
	public string Page { get; set; }

	public string LocalTimestamp { get; set; }

	public int? TotalInSort { get; set; }

	public string Context { get; set; }

	public long PlaceId { get; set; }

	public bool IsNativeAd { get; set; }

	public string ExperimentalContext { get; set; }
}
