using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Messages;

/// <summary>
/// Creates <see cref="T:Roblox.Platform.Social.Messages.IMessagePrivacySettingEntity" />. This is a mockable wrapper for a legacy entity file that is untestable.
/// There should be no logic in the implementation of this interface.
/// </summary>
internal interface IMessagePrivacySettingEntityFactory
{
	IMessagePrivacySettingEntity GetOrCreate(IUser user);
}
