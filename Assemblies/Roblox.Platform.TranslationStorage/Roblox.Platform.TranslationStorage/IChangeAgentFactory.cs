using Roblox.Platform.Membership;

namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// An interface to get an <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.
/// </summary>
public interface IChangeAgentFactory
{
	/// <summary>
	/// Gets the change agent for user.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <returns>An <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" /> corresponding to the user.</returns>
	IChangeAgent GetChangeAgentForUser(IUser user);

	/// <summary>
	/// Gets the change agent for automation.
	/// </summary>
	/// <param name="automationType">Type of the automation.</param>
	/// <returns>An <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" /> corresponding to AutomationType.</returns>
	IChangeAgent GetChangeAgentForAutomation(AutomationType automationType);
}
