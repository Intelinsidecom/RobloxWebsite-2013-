using Roblox.Platform.Core;

namespace Roblox.Platform.XboxLive;

/// <summary>
/// Builds <see cref="T:Roblox.Platform.XboxLive.CrossPlaySetting" /> instances.
/// </summary>
/// <seealso cref="!:Roblox.Platform.Core.IDomainFactory&lt;Roblox.Platform.XboxLive.XboxDomainFactories&gt;" />
internal interface ICrossPlaySettingEntityFactory : IDomainFactory<XboxDomainFactories>, IDomainObject<XboxDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.XboxLive.ICrossPlaySettingEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.XboxLive.ICrossPlaySettingEntity" /> with the given ID, or null if none existed.</returns>
	ICrossPlaySettingEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.XboxLive.ICrossPlaySettingEntity" /> with the given user ID
	/// </summary>
	/// <param name="userId">The user identifier.</param>
	/// <returns>
	/// The <see cref="T:Roblox.Platform.XboxLive.ICrossPlaySettingEntity" />
	/// </returns>
	ICrossPlaySettingEntity GetByUserId(long userId);

	ICrossPlaySettingEntity CreateNew(long userId, bool isEnabled);
}
