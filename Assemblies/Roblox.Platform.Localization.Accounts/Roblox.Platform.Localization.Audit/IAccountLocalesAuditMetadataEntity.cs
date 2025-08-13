using System;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Audit;

internal interface IAccountLocalesAuditMetadataEntity : IEntity<long>
{
	Guid AccountLocalesAuditEntryPublicId { get; }

	long AccountLocalesAuditEntryAuditId { get; }

	byte AccountLocalesAuditMetadataTypeId { get; }

	byte ChangeAgentTypeId { get; }

	long? ChangeAgentTargetId { get; }
}
