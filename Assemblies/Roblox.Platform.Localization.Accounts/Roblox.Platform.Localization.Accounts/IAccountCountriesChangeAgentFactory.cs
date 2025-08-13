using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

public interface IAccountCountriesChangeAgentFactory
{
	/// <summary>
	/// Creates a <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesChangeAgent" /> for a specific user.
	/// </summary>
	/// <param name="changeAgentType"></param>
	/// <param name="changeAgentTargetUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> who is changing the country.</param>
	/// <returns>A <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesChangeAgent" />.</returns>
	IAccountCountriesChangeAgent CreateChangeAgentForUser(AccountCountriesChangeAgentType changeAgentType, IUser changeAgentTargetUser);

	/// <summary>
	/// Creates a <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesChangeAgent" /> for an automated change agent.
	/// </summary>
	/// <param name="changeAgentAutomationType">The <see cref="T:Roblox.Platform.Localization.Accounts.AccountCountriesAutomationType" />.</param>
	/// <returns>A <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesChangeAgent" />.</returns>
	IAccountCountriesChangeAgent CreateChangeAgentForAutomation(AccountCountriesAutomationType changeAgentAutomationType);
}
