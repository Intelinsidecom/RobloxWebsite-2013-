using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

public class AccountCountriesChangeAgentFactory : IAccountCountriesChangeAgentFactory
{
	private readonly IAccountCountriesAutomationTypeConverter _AutomationTypeConverter;

	public AccountCountriesChangeAgentFactory()
	{
		AccountCountriesAutomationTypeEntityFactory automationTypeEntityFactory = new AccountCountriesAutomationTypeEntityFactory();
		_AutomationTypeConverter = new AccountCountriesAutomationTypeConverter(automationTypeEntityFactory);
	}

	internal AccountCountriesChangeAgentFactory(IAccountCountriesAutomationTypeEntityFactory automationEntityFactory)
	{
		_AutomationTypeConverter = new AccountCountriesAutomationTypeConverter(automationEntityFactory);
	}

	public IAccountCountriesChangeAgent CreateChangeAgentForUser(AccountCountriesChangeAgentType changeAgentType, IUser changeAgentTargetUser)
	{
		if (changeAgentTargetUser == null)
		{
			throw new PlatformArgumentNullException("changeAgentTargetUser");
		}
		if (changeAgentType != 0 && changeAgentType != AccountCountriesChangeAgentType.CsAgent)
		{
			throw new PlatformArgumentException(string.Format("{0} must be either User or CsAgent.", "changeAgentType"));
		}
		return new AccountCountriesChangeAgent(changeAgentType, changeAgentTargetUser.Id);
	}

	public IAccountCountriesChangeAgent CreateChangeAgentForAutomation(AccountCountriesAutomationType changeAgentAutomationType)
	{
		byte changeAgentTargetId = _AutomationTypeConverter.GetEntityIdFromEnum(changeAgentAutomationType);
		return new AccountCountriesChangeAgent(AccountCountriesChangeAgentType.Automation, changeAgentTargetId);
	}
}
