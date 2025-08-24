using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal interface IRecentItemListTypeEntityFactory : IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	IRecentItemListTypeEntity Clothing { get; }

	IRecentItemListTypeEntity BodyParts { get; }

	IRecentItemListTypeEntity AvatarAnimations { get; }

	IRecentItemListTypeEntity Accessories { get; }

	IRecentItemListTypeEntity Outfits { get; }

	IRecentItemListTypeEntity Gear { get; }

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Avatar.IRecentItemListTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Avatar.IRecentItemListTypeEntity" /> with the given ID, or null if none existed.
	/// </returns>
	IRecentItemListTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Avatar.IRecentItemListTypeEntity" /> with the given value
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Avatar.IRecentItemListTypeEntity" /> with the given value
	/// </returns>
	IRecentItemListTypeEntity GetByValue(string value);
}
