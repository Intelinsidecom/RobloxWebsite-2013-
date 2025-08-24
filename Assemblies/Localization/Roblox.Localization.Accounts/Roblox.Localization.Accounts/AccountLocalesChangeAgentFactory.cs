using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

public class AccountLocalesChangeAgentFactory : IAccountLocalesChangeAgentFactory
{
	private readonly IAccountLocalesAutomationTypeConverter _AutomationTypeConverter;

	public AccountLocalesChangeAgentFactory()
	{
		AccountLocalesAutomationTypeEntityFactory automationTypeEntityFactory = new AccountLocalesAutomationTypeEntityFactory();
		_AutomationTypeConverter = new AccountLocalesAutomationTypeConverter(automationTypeEntityFactory);
	}

	internal AccountLocalesChangeAgentFactory(IAccountLocalesAutomationTypeEntityFactory automationTypeEntityFactory)
	{
		_AutomationTypeConverter = new AccountLocalesAutomationTypeConverter(automationTypeEntityFactory);
	}

	public IAccountLocalesChangeAgent CreateChangeAgentForUser(AccountLocalesChangeAgentType changeAgentType, IUser changeAgentTargetUser)
	{
		if (changeAgentTargetUser == null)
		{
			throw new PlatformArgumentNullException("changeAgentTargetUser");
		}
		if (changeAgentType <= AccountLocalesChangeAgentType.CsAgent)
		{
			return new AccountLocalesChangeAgent(changeAgentType, changeAgentTargetUser.Id);
		}
		throw new PlatformArgumentException(string.Format("{0} must be either User or CsAgent.", "changeAgentType"));
	}

	public IAccountLocalesChangeAgent CreateChangeAgentForAutomation(AccountLocalesAutomationType changeAgentAutomationType)
	{
		byte changeAgentTargetId = _AutomationTypeConverter.GetEntityIdFromEnum(changeAgentAutomationType);
		return new AccountLocalesChangeAgent(AccountLocalesChangeAgentType.Automation, changeAgentTargetId);
	}
}
