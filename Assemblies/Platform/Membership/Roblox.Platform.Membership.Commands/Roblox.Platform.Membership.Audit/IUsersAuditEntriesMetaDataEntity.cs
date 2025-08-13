using System;
using Roblox.Entities;

namespace Roblox.Platform.Membership.Audit;

internal interface IUsersAuditEntriesMetaDataEntity : IEntity<long>
{
	long UserId { get; }

	byte UsersAuditEntriesMetaDataTypeId { get; }

	Guid UsersAuditEntriesPublicId { get; }

	long ActorUserId { get; }

	bool IsLegacyValue { get; }
}
