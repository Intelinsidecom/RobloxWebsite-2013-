using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

public interface IPlayerAvatarTypeEntityFactory : IDomainFactory<OutfitDomainFactories>, IDomainObject<OutfitDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Outfits.IPlayerAvatarTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Outfits.IPlayerAvatarTypeEntity" /> with the given ID, or null if none existed.</returns>
	IPlayerAvatarTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Outfits.IPlayerAvatarTypeEntity" /> with the given id.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Outfits.IPlayerAvatarTypeEntity" /> with the given value</returns>
	IPlayerAvatarTypeEntity GetByValue(string value);
}
