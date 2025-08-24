using System;

namespace Roblox.Platform.Games.PrivateServer;

/// <summary>
/// Represents a Virtual Private Server
/// </summary>
public interface IPrivateServer
{
	long Id { get; }

	long UniverseId { get; }

	string Name { get; set; }

	long OwnerUserId { get; }

	PrivateServerStatusType StatusType { get; set; }

	Guid AccessCode { get; }

	DateTime ExpirationDate { get; set; }

	DateTime Created { get; }

	DateTime Updated { get; }

	string LinkCode { get; set; }
}
