using System;
using Roblox.Entities;
namespace Roblox.Localization.Auditinternal {
    interface IAccountLocalesAuditEntryEntity : IEntity<long>

{
	Guid PublicId { get; }

	long AuditId { get; }

	long AuditAccountId { get; }

	int AuditObservedLocaleId { get; }

	int? AuditSupportedLocaleId { get; }

	DateTime AuditCreated { get; }

	DateTime AuditUpdated { get; }
}


}
