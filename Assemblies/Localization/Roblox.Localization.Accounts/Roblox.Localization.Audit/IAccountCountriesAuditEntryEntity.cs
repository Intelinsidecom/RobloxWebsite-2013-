using System;
using Roblox.Entities;
namespace Roblox.Localization.Audit {
    interface IAccountCountriesAuditEntryEntity : IEntity<long>

{
	Guid PublicId { get; }

	long AuditId { get; }

	long AuditAccountId { get; }

	int? AuditCountryId { get; }

	bool AuditIsVerified { get; }

	DateTime AuditCreated { get; }

	DateTime AuditUpdated { get; }
}


}
