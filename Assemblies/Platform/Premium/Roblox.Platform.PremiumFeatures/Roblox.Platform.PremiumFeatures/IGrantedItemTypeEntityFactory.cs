namespace Roblox.PremiumFeatures;

public interface IGrantedItemTypeEntityFactory
{
	/// <summary>
	/// The GrantedItemType for Assets 
	/// </summary>
	IGrantedItemTypeEntity Asset { get; }

	/// <summary>
	/// The GrantedItemType for Bundles 
	/// </summary>
	IGrantedItemTypeEntity Bundle { get; }

	/// <summary>
	/// Gets an <see cref="T:Roblox.PremiumFeatures.IGrantedItemTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IGrantedItemTypeEntity" /> with the given ID, or null if none existed.</returns>
	IGrantedItemTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.PremiumFeatures.IGrantedItemTypeEntity" /> with the given value.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IGrantedItemTypeEntity" /> with the given value, or null if none existed.</returns>
	IGrantedItemTypeEntity GetByValue(string value);
}
