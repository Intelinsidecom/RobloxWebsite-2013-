using System;

namespace Roblox.Platform.Infrastructure;

/// <summary>
/// This interface represents information from table ServerGroupMembership.
/// </summary>
public interface IServerGroupMember : IEquatable<IServerGroupMember>
{
	int Id { get; }

	int ServerId { get; }

	ServerGroup ServerGroup { get; }

	DateTime CreatedUtc { get; }
}
