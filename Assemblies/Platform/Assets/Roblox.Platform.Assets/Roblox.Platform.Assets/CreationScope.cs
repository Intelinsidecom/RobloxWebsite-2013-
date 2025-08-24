namespace Roblox.Platform.Assets;

internal class CreationScope : ICreationScope
{
	public int AssetTypeId { get; private set; }

	public CreationContextType CreationContextType { get; private set; }

	public CreatorType CreatorType { get; private set; }

	public long CreatorTargetId { get; private set; }

	internal CreationScope(CreationContextType creationContextType, CreatorType creatorType, long creatorTargetId, int assetTypeId)
	{
		CreationContextType = creationContextType;
		CreatorType = creatorType;
		CreatorTargetId = creatorTargetId;
		AssetTypeId = assetTypeId;
	}
}
