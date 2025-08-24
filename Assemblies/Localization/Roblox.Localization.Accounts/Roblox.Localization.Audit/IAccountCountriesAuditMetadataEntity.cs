using System;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Audit;

public interface IAccountCountriesAuditMetadataEntity : IEntity<long>
{
	Guid AccountCountriesAuditEntryPublicId { get; }

	long AccountCountriesAuditEntryAuditId { get; }

	byte AccountCountriesAuditMetadataTypeId { get; }

	byte ChangeAgentTypeId { get; }

	long? ChangeAgentTargetId { get; }
}
