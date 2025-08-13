using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Entities.Audit;

internal interface IAssetChangeTypesEntityFactory : IDomainFactory<AssetDomainFactories>, IDomainObject<AssetDomainFactories>
{
	/// <summary>
	/// Returns the Id of the ChangeType using the name of the enum as value lookup.
	/// </summary>
	/// <exception cref="T:Roblox.Data.DataIntegrityException">If no record can be found matching the name of the enum as its value.</exception>
	byte GetIdByEnum(AssetChangeType changeType);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetChangeTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetChangeTypeEntity" /> with the given ID, or null if none exists.</returns>
	IAssetChangeTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetChangeTypeEntity" /> with the given value
	/// </summary>
	IAssetChangeTypeEntity GetByValue(string value);
}
