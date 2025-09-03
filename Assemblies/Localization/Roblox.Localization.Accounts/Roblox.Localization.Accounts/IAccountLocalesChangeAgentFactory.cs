using Roblox.Platform.Membership;
namespace Roblox.Localization.Accounts {
    interface IAccountLocalesChangeAgentFactory

{
	/// <summary>
	/// Creates an <see cref="T:Roblox.Localization.Accounts.AccountLocalesChangeAgent" /> for a user.
	/// </summary>
	/// <param name="changeAgentType">Either User or CsAgent.</param>
	/// <param name="changeAgentTargetUser">The change agent user.</param>
	/// <returns><see cref="T:Roblox.Localization.Accounts.IAccountLocalesChangeAgent" />.</returns>
	IAccountLocalesChangeAgent CreateChangeAgentForUser(AccountLocalesChangeAgentType changeAgentType, IUser changeAgentTargetUser);

	/// <summary>
	/// Creates an <see cref="T:Roblox.Localization.Accounts.AccountLocalesChangeAgent" /> for an automated process.
	/// </summary>
	/// <param name="changeAgentAutomationType"></param>
	/// <returns><see cref="T:Roblox.Localization.Accounts.IAccountLocalesChangeAgent" />.</returns>
	IAccountLocalesChangeAgent CreateChangeAgentForAutomation(AccountLocalesAutomationType changeAgentAutomationType);
}


}
