using Roblox.Platform.Core;

namespace Roblox.Platform.UserSetting.Entities;

internal interface IUserSettingEntityFactory : IDomainFactory<UserSettingDomainFactories>, IDomainObject<UserSettingDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.UserSetting.Entities.IUserSettingEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.UserSetting.Entities.IUserSettingEntity" /> with the given ID, or null if none existed.</returns>
	IUserSettingEntity Get(long id);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.UserSetting.Entities.IUserSettingEntity" /> with the given userId and default values
	/// </summary>
	/// <param name="userId"></param>
	/// <returns>The <see cref="T:Roblox.Platform.UserSetting.Entities.IUserSettingEntity" /> for the given userId. </returns>
	IUserSettingEntity GetOrCreate(long userId);
}
