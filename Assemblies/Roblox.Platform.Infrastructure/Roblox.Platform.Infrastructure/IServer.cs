using System;

namespace Roblox.Platform.Infrastructure;

public interface IServer : IEquatable<IServer>
{
	int Id { get; }

	string HostName { get; }

	string Name { get; }

	short ServerFarmId { get; }

	int ServerTypeId { get; }

	int DatacenterId { get; }

	string PrivateIPAddress { get; }

	string PrimaryIPAddress { get; }

	DateTime UpdatedUtc { get; }
}
