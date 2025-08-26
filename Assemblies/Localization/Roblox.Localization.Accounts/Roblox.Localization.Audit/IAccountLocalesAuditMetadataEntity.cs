using System;
using Roblox.Entities;
namespace Roblox.Localization.Auditinternal {
    interface IAccountLocalesAuditMetadataEntity : IEntity<long>

{
	Guid AccountLocalesAuditEntryPublicId { get; }

	long AccountLocalesAuditEntryAuditId { get; }

	byte AccountLocalesAuditMetadataTypeId { get; }

	byte ChangeAgentTypeId { get; }

	long? ChangeAgentTargetId { get; }
}


}
