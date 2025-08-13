namespace Roblox.PremiumFeatures;

public interface IMembershipMigrationStateEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.PremiumFeatures.IMembershipMigrationStateEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IMembershipMigrationStateEntity" /> with the given ID, or null if none existed.</returns>
	IMembershipMigrationStateEntity Get(int id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.PremiumFeatures.IMembershipMigrationStateEntity" /> by its value.
	/// </summary>
	/// <param name="value">The value</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IMembershipMigrationStateEntity" /> with the given value, or null if none existed.</returns>
	IMembershipMigrationStateEntity GetByValue(string value);
}
