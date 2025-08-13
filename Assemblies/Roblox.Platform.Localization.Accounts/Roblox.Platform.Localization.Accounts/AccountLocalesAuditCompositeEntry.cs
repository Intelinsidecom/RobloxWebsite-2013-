using System;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocalesAuditCompositeEntry : IAccountLocalesAuditCompositeEntry
{
	private readonly IAccountLocalesAuditMetadataEntity _Metadata;

	private readonly IAccountLocalesAuditEntryEntity _AuditEntry;

	private readonly IUserFactory _UserFactory;

	private readonly IAccountLocalesAutomationTypeEntityFactory _AutomationTypeEntityFactory;

	public long Id => _Metadata.Id;

	public long AccountLocaleId => _Metadata.AccountLocalesAuditEntryAuditId;

	public AccountLocalesAuditEntryMetadataType MetadataType { get; internal set; }

	public AccountLocalesChangeAgentType ChangeAgentType { get; internal set; }

	public long? ChangeAgentTargetId => _Metadata.ChangeAgentTargetId;

	public int? AuditObservedLocaleId => _AuditEntry?.AuditObservedLocaleId;

	public int? AuditSupportedLocaleId => _AuditEntry?.AuditSupportedLocaleId;

	public DateTime? AuditUpdated => _AuditEntry?.AuditUpdated;

	public DateTime? AuditCreated => _AuditEntry.AuditCreated;

	public long? AuditAccountId => _AuditEntry.AuditAccountId;

	internal AccountLocalesAuditCompositeEntry(IAccountLocalesAuditMetadataEntity metadata, IAccountLocalesAuditEntryEntity auditEntry, IUserFactory userFactory, IAccountLocalesAutomationTypeEntityFactory automationTypeEntityFactory)
	{
		_Metadata = metadata.AssignOrThrowIfNull("metadata");
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
		_AutomationTypeEntityFactory = automationTypeEntityFactory.AssignOrThrowIfNull("automationTypeEntityFactory");
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
		case AccountLocalesChangeAgentType.User:
		case AccountLocalesChangeAgentType.CsAgent:
			return _UserFactory.GetUser(ChangeAgentTargetId.Value)?.Name;
		case AccountLocalesChangeAgentType.Automation:
			return _AutomationTypeEntityFactory.Get((byte)ChangeAgentTargetId.Value)?.Value;
		default:
			return null;
		}
	}
}
