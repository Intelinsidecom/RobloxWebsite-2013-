namespace Roblox.Web.Code.Mobile;

public class MobileGamesNotSupportedModel
{
	public enum NotSupportedReason
	{
		OSUpgradeRequired,
		NotAvailable
	}

	public int MinimumVersionRequired;

	public int CurrentVersion;

	public NotSupportedReason Reason { get; set; }
}
