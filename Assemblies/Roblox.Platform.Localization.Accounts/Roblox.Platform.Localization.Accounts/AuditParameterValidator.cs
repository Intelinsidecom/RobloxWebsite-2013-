using System;
using Roblox.Common;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AuditParameterValidator : IAuditParameterValidator
{
	private readonly ISettings _Settings;

	private readonly IUserFactory _UserFactory;

	private readonly IAccountCountriesAutomationTypeEntityFactory _AutomationTypeEntityFactory;

	public AuditParameterValidator(ISettings settings, IUserFactory userFactory, IAccountCountriesAutomationTypeEntityFactory automationTypeEntityFactory)
	{
		_Settings = settings.AssignOrThrowIfNull("settings");
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
		_AutomationTypeEntityFactory = automationTypeEntityFactory.AssignOrThrowIfNull("automationTypeEntityFactory");
	}

	public void ValidateChangeAgent(IAccountCountriesChangeAgent changeAgent)
	{
		if (!_Settings.IsAccountCountriesTableAuditingEnabled)
		{
			return;
		}
		if (changeAgent == null)
		{
			throw new PlatformArgumentNullException("changeAgent");
		}
		AccountCountriesChangeAgentType changeAgentType = changeAgent.ChangeAgentType;
		long changeAgentTargetId = changeAgent.ChangeAgentTargetId;
		switch (changeAgentType)
		{
		case AccountCountriesChangeAgentType.User:
		case AccountCountriesChangeAgentType.CsAgent:
			if (_UserFactory.GetUser(changeAgentTargetId) == null)
			{
				throw new PlatformArgumentNullException($"The user with Id: {changeAgentTargetId} was null.");
			}
			break;
		case AccountCountriesChangeAgentType.Automation:
		{
			IAccountCountriesAutomationTypeEntity automationTypeEntity = _AutomationTypeEntityFactory.Get((byte)changeAgentTargetId);
			if (automationTypeEntity == null)
			{
				throw new PlatformArgumentException(string.Format("{0} could not be converted to a valid AccountCountriesAutomationType. TargetId: {1}.", "changeAgentTargetId", changeAgentTargetId));
			}
			if (!EnumUtils.StrictTryParseEnum<AccountCountriesAutomationType>(automationTypeEntity.Value).HasValue)
			{
				throw new PlatformException($"AutomationType: {automationTypeEntity.Value}, does not match any enum. Please corect this difference.");
			}
			break;
		}
		default:
			throw new NotImplementedException($"Please define the validation for this new type of AccountCountriesChangeAgent: {changeAgentType.ToString()}.");
		}
	}
}
