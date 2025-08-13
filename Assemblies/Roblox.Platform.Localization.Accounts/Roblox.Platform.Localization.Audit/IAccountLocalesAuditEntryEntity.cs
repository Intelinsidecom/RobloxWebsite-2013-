using System;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Audit;

internal interface IAccountLocalesAuditEntryEntity : IEntity<long>
{
	Guid PublicId { get; }

	long AuditId { get; }

	long AuditAccountId { get; }

	int AuditObservedLocaleId { get; }

	int? AuditSupportedLocaleId { get; }

	DateTime AuditCreated { get; }

	DateTime AuditUpdated { get; }
}
