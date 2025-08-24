using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

internal interface IScaleEntityFactory : IDomainFactory<OutfitDomainFactories>, IDomainObject<OutfitDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Outfits.IScaleEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Outfits.IScaleEntity" /> with the given ID, or null if none existed.
	/// </returns>
	IScaleEntity Get(int id);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Outfits.IScaleEntity" /> with the given height, width, and head, proportion, and bodyType
	/// </summary>
	IScaleEntity GetOrCreate(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Outfits.IScaleEntity" /> with the default height, width, head, proportion, and bodyType
	/// </summary>
	IScaleEntity GetDefault();
}
