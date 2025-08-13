using System;

namespace Roblox.Platform.Membership.UserDataAuditCore;

public interface IAuditMetadata
{
	Guid ForeignPublicId { get; }

	long? ActorUserId { get; }
}
