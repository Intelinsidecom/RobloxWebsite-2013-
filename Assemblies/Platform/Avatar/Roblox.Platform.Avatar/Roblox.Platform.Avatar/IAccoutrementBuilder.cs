namespace Roblox.Platform.Avatar;

public interface IAccoutrementBuilder
{
	/// <summary>
	/// Creates a new accoutrement
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Avatar.DuplicateAccoutrementInsertException">Thrown when an accoutrement already exists for this UserAssetID</exception>
	IAccoutrement CreateNew(long userId, long userAssetId);
}
