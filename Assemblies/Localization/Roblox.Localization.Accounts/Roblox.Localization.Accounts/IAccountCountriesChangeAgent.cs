namespace Roblox.Platform.Localization.Accounts;

public interface IAccountCountriesChangeAgent
{
	AccountCountriesChangeAgentType ChangeAgentType { get; }

	long ChangeAgentTargetId { get; }
}
