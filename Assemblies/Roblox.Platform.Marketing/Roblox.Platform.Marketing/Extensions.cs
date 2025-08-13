namespace Roblox.Platform.Marketing;

public static class Extensions
{
	internal static void VerifyIsNotNull(this IBrowserTracker browserTracker)
	{
		if (browserTracker == null || browserTracker.Id == 0L)
		{
			throw new UnknownBrowserTrackerException();
		}
	}
}
