namespace Roblox.Platform.Assets;

public interface ICreationScope
{
	int AssetTypeId { get; }

	CreationContextType CreationContextType { get; }

	CreatorType CreatorType { get; }

	long CreatorTargetId { get; }
}
