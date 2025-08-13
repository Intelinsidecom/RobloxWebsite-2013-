using Roblox.Properties;

namespace Roblox;

public static class GlobalProperties
{
	public static bool IsTestingSite => Settings.Default.IsTestingSite;

	public static bool CommentsPostingEnabled => Settings.Default.CommentsPostingEnabled;

	public static bool CommentPostingFloodCheckOn => Settings.Default.CommentPostingFloodCheckingOn;

	public static int CommentPostingIntervalInSeconds => Settings.Default.CommentPostingIntervalInSeconds;

	public static bool SetsEnabled => Settings.Default.SetsEnabled;

	public static string CLSID32Bit => Settings.Default.CLSID32Bit;

	public static bool InteractionTrackingIsEnabled => Settings.Default.InteractionTrackingIsEnabled;

	public static bool AsyncGoogleOn => Settings.Default.AsyncGoogleOn;
}
