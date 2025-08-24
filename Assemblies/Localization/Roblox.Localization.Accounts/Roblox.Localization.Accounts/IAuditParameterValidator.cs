namespace Roblox.Platform.Localization.Accounts;

internal interface IAuditParameterValidator
{
	void ValidateChangeAgent(IAccountCountriesChangeAgent changeAgent);
}
