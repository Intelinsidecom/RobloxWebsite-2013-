using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.UserSetting.Entities;

namespace Roblox.Platform.UserSetting;

/// <summary>
/// Wrapper for the UserSetting factories.
/// </summary>
public class UserSettingDomainFactories : DomainFactoriesBase
{
	internal virtual IUserSettingEntityFactory UserSettingEntityFactory { get; set; }

	internal virtual IRoleSetValidator RoleSetValidator { get; set; }

	/// <summary>
	/// Factory for accessing the UserSettings.
	/// </summary>
	public virtual IUserSettingsFactory UserSettingsFactory { get; }

	/// <summary>
	/// Validator for checking what features are enabled.
	/// </summary>
	public virtual IUserSettingsValidator UserSettingsValidator { get; }

	/// <summary>
	/// Default constructor
	/// </summary>
	public UserSettingDomainFactories(IRoleSetValidator roleSetValidator)
	{
		RoleSetValidator = roleSetValidator.AssignOrThrowIfNull("roleSetValidator");
		UserSettingEntityFactory = new UserSettingEntityFactory(this);
		UserSettingsFactory = new UserSettingsFactory(this);
		UserSettingsValidator = new UserSettingsValidator(this);
	}
}
