using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AddCloudEditorFloodChecker : FloodChecker
{
	public AddCloudEditorFloodChecker(long inviterId, long universeId)
		: base("CloudEdit", string.Format($"AddCloudEditor_UserId:{inviterId}_UniverseId:{universeId}"), Settings.Default.AddCloudEditorFloodCheckerLimit, Settings.Default.AddCloudEditorFloodCheckerExpiry)
	{
	}
}
