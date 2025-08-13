using System;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocalesAuditParameterValidator : IAccountLocalesAuditParameterValidator
{
	private readonly ISettings _Settings;

	private readonly IUserFactory _UserFactory;

	private readonly IAccountLocalesAutomationTypeEntityFactory _AutomationTypeEntityFactory;

	public AccountLocalesAuditParameterValidator(ISettings settings, IUserFactory userFactory, IAccountLocalesAutomationTypeEntityFactory automationTypeEntityFactory)
	{
		_Settings = settings.AssignOrThrowIfNull("automationTypeEntityFactory");
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
		_AutomationTypeEntityFactory = automationTypeEntityFactory.AssignOrThrowIfNull("automationTypeEntityFactory");
	}

	public void ValidateChangeAgent(IAccountLocalesChangeAgent changeAgent)
	{
		if (!_Settings.IsAccountLocalesTableAuditingEnabled)
		{
			return;
		}
		if (changeAgent == null)
		{
			throw new PlatformArgumentNullException("changeAgent");
		}
		AccountLocalesChangeAgentType changeAgentType = changeAgent.ChangeAgentType;
		long changeAgentTargetId = changeAgent.ChangeAgentTargetId;
		switch (changeAgentType)
		{
		case AccountLocalesChangeAgentType.User:
		case AccountLocalesChangeAgentType.CsAgent:
			if (_UserFactory.GetUser(changeAgentTargetId) == null)
			{
				throw new PlatformArgumentNullException($"The user with Id: {changeAgentTargetId} was null.");
			}
			break;
		case AccountLocalesChangeAgentType.Automation:
			if (_AutomationTypeEntityFactory.Get((byte)changeAgentTargetId) == null)
			{
				throw new PlatformArgumentException(string.Format("{0} could not be converted to a valid AccountCountriesAutomationType. TargetId: {1}.", "changeAgentTargetId", changeAgentTargetId));
			}
			break;
		default:
			throw new NotImplementedException($"Pleaes define validation behavior for {changeAgentType.ToString()}.");
		}
	}
}
