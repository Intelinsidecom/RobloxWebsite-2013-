using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocaleAuditBuilder : IAccountLocaleAuditBuilder
{
	private readonly IAccountLocalesAuditEntryEntityFactory _AccountLocalesAuditEntryEntityFactory;

	private readonly IAccountLocalesAuditMetadataEntityFactory _AccountLocalesAuditMetadataEntityFactory;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	public AccountLocaleAuditBuilder(IAccountLocalesAuditEntryEntityFactory accountLocalesAuditEntryEntityFactory, IAccountLocalesAuditMetadataEntityFactory accountLocalesAuditMetadataEntityFactory, ISettings settings, ILogger logger)
	{
		_AccountLocalesAuditEntryEntityFactory = accountLocalesAuditEntryEntityFactory.AssignOrThrowIfNull("accountLocalesAuditEntryEntityFactory");
		_AccountLocalesAuditMetadataEntityFactory = accountLocalesAuditMetadataEntityFactory.AssignOrThrowIfNull("accountLocalesAuditMetadataEntityFactory");
		_Settings = settings.AssignOrThrowIfNull("settings");
		_Logger = logger.AssignOrThrowIfNull("logger");
	}

	public void CreateAuditRecords(IAccountLocaleEntity accountLocaleEntity, IAccountLocalesChangeAgent changeAgent, AccountLocalesAuditEntryMetadataType metadataType)
	{
		try
		{
			if (_Settings.IsAccountLocalesTableAuditingEnabled)
			{
				IAccountLocalesAuditEntryEntity auditEntry = _AccountLocalesAuditEntryEntityFactory.Create(accountLocaleEntity);
				_AccountLocalesAuditMetadataEntityFactory.Create(auditEntry, metadataType, changeAgent.ChangeAgentType, changeAgent.ChangeAgentTargetId);
			}
		}
		catch (Exception e)
		{
			_Logger.Error($"Error trying to create audit records. Message: {e}");
		}
	}
}
