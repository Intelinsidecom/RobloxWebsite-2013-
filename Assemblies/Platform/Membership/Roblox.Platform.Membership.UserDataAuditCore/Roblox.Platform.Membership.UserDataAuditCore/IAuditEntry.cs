using System;

namespace Roblox.Platform.Membership.UserDataAuditCore;

public interface IAuditEntry
{
	Guid PublicId { get; }
}
