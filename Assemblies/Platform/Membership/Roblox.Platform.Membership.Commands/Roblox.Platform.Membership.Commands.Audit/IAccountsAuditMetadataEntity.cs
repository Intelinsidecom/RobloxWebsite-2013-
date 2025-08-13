using System;
using Roblox.Entities;

namespace Roblox.Platform.Membership.Commands.Audit;

internal interface IAccountsAuditMetadataEntity : IEntity<long>
{
	Guid AccountsAuditEntriesPublicId { get; }

	byte AccountsChangeTypeId { get; }

	long? ActorUserId { get; }

	long UserId { get; }
}
