namespace Roblox.Platform.Assets;

/// <summary>
/// A public interface for the factory producing <see cref="T:Roblox.Platform.Assets.ICreationScope" />
/// </summary>
public interface ICreationScopeFactory
{
	/// <summary>
	/// Builds a <see cref="T:Roblox.Platform.Assets.ICreationScope" /> with the specified information
	/// </summary>
	ICreationScope BuildCreationScope(CreationContextType creationContextType, CreatorType creatorType, int creatorTargetId, int assetTypeId);
}
