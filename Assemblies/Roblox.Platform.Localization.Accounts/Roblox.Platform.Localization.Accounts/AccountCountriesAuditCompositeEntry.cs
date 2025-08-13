using System;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountCountriesAuditCompositeEntry : IAccountCountriesAuditCompositeEntry
{
	private readonly IAccountCountriesAuditMetadataEntity _Metadata;

	private readonly IAccountCountriesAuditEntryEntity _AuditEntry;

	private readonly IUserFactory _UserFactory;

	private readonly IAccountCountriesAutomationTypeEntityFactory _AutomationTypeEntityFactory;

	public long Id => _Metadata.Id;

	public long AccountCountriesId => _Metadata.AccountCountriesAuditEntryAuditId;

	public AccountCountriesAuditEntryMetadataType MetadataType { get; internal set; }

	public AccountCountriesChangeAgentType ChangeAgentType { get; internal set; }

	public long? ChangeAgentTargetId => _Metadata.ChangeAgentTargetId;

	public int? AuditCountryId => _AuditEntry?.AuditCountryId;

	public DateTime? AuditUpdated => _AuditEntry?.AuditUpdated;

	public DateTime? AuditCreated => _AuditEntry?.AuditCreated;

	public long? AuditAccountID => _AuditEntry?.AuditAccountId;

	internal AccountCountriesAuditCompositeEntry(IAccountCountriesAuditMetadataEntity metadata, IAccountCountriesAuditEntryEntity auditEntry, IUserFactory userFactory, IAccountCountriesAutomationTypeEntityFactory automationTypeEntityFactory)
	{
		_Metadata = metadata ?? throw new PlatformArgumentNullException("metadata");
		_UserFactory = userFactory ?? throw new PlatformArgumentNullException("userFactory");
		_AutomationTypeEntityFactory = automationTypeEntityFactory ?? throw new PlatformArgumentNullException("automationTypeEntityFactory");
		_AuditEntry = auditEntry;
	}

	public string GetChangeAgentName()
	{
		if (!ChangeAgentTargetId.HasValue)
		{
			return null;
		}
		switch (ChangeAgentType)
		{
		case AccountCountriesChangeAgentType.User:
		case AccountCountriesChangeAgentType.CsAgent:
			return _UserFactory.GetUser(ChangeAgentTargetId.Value)?.Name;
		case AccountCountriesChangeAgentType.Automation:
			return _AutomationTypeEntityFactory.Get((byte)ChangeAgentTargetId.Value)?.Value;
		default:
			return null;
		}
	}
}
