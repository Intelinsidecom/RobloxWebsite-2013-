using Roblox.Platform.Membership;

namespace Roblox.Platform.Games.PrivateServer;

public interface IPrivateServerPrivacySettingFactory
{
	IPrivateServerPrivacySetting GetOrCreate(IUser user);
}
