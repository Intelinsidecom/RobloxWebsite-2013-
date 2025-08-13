namespace Roblox.PremiumFeatures;

public interface IGrantedItemListEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.PremiumFeatures.IGrantedItemListEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IGrantedItemListEntity" /> with the given ID, or null if none existed.</returns>
	IGrantedItemListEntity Get(long id);

	/// <summary>
	/// Creates an <see cref="T:Roblox.PremiumFeatures.IGrantedItemListEntity" />
	/// </summary>
	IGrantedItemListEntity Create(string name);
}
