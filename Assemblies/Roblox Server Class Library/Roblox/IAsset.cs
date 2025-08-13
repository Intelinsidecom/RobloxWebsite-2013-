namespace Roblox;

/// <summary>
/// Implementing classes: Asset, AssetVersion
/// </summary>
public interface IAsset
{
	AssetVersion CurrentVersion { get; }

	ICreator Creator { get; }

	CreatorRef CreatorRefObject { get; }

	long AssetHashID { get; }

	string Description { get; }

	string Hash { get; }

	bool IsApproved { get; }

	bool IsHashDynamic { get; }

	bool IsReviewed { get; }

	bool? IsArchived { get; }

	string Name { get; }

	AssetType Type { get; }

	bool IsCreator(ICreator creator);
}
