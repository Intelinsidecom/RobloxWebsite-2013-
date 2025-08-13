namespace Roblox.Platform.Assets;

/// <summary>
/// Wrapper class for submitting data for an Asset's Creator.
/// </summary>
public class AssetCreatorInfo
{
	public CreatorType CreatorType { get; }

	public long CreatorTargetId { get; }

	public long? CreatingUniverseId { get; }

	public CreationContextType CreationContext { get; }

	public AssetCreatorInfo(CreatorType creatorType, long creatorTargetId, long? creatingUniverseId = null, CreationContextType creationContext = CreationContextType.NonGameCreation)
	{
		CreatorType = creatorType;
		CreatorTargetId = creatorTargetId;
		CreatingUniverseId = creatingUniverseId;
		CreationContext = creationContext;
	}
}
