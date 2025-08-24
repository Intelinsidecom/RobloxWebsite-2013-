using Roblox.Platform.Privacy;

namespace Roblox.Platform.Games.PrivateServer;

public interface IPrivateServerPrivacySetting
{
	UserPrivacyLevelType PrivacyLevel { get; }

	/// <summary>
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Permissions.Core.InvalidPermissionTypeException">Thrown if trying to update the privacy level to an invalid value</exception>
	void UpdatePrivacyLevel(UserPrivacyLevelType newPrivacyLevel);

	void Sanitize();
}
