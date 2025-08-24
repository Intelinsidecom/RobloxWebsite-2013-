namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// Provides a container for AccountLocaleChangeAgent details.
/// </summary>
public interface IAccountLocalesChangeAgent
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Localization.Accounts.AccountLocalesChangeAgentType" />.
	/// </summary>
	AccountLocalesChangeAgentType ChangeAgentType { get; }

	/// <summary>
	/// The id of the change agent.
	/// </summary>
	long ChangeAgentTargetId { get; }
}
