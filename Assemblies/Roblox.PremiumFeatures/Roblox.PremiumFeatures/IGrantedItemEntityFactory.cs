using System.Collections.Generic;

namespace Roblox.PremiumFeatures;

public interface IGrantedItemEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.PremiumFeatures.IGrantedItemEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IGrantedItemEntity" /> with the given ID, or null if none existed.</returns>
	IGrantedItemEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.PremiumFeatures.IGrantedItemEntity" />s by their grantedItemListId.
	/// </summary>
	/// <param name="grantedItemListId">The ID of the granted item list to retrieve items for.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:System.ArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.PremiumFeatures.IGrantedItemEntity" />s.</returns>
	ICollection<IGrantedItemEntity> GetByGrantedItemListIdEnumerative(long grantedItemListId, int count, long? exclusiveStartId = null);

	/// <summary>
	/// Creates an <see cref="T:Roblox.PremiumFeatures.IGrantedItemEntity" />
	/// </summary>
	IGrantedItemEntity Create(long grantedItemListId, byte grantedItemTypeId, long grantedItemTargetId);
}
