using System;
using Roblox.Entities;

namespace Roblox.Platform.IpAddresses;

/// <summary>
/// Associative entity between accounts and IP addresses on which they have been seen.
/// </summary>
public interface IAccountIpAddressEntity : IEntity<long>
{
	/// <summary>
	/// The account id
	/// </summary>
	long AccountId { get; }

	/// <summary>
	/// The IpAddress id
	/// </summary>
	long IpAddressId { get; }

	/// <summary>
	/// Last seen time
	/// </summary>
	DateTime? LastSeen { get; }

	/// <summary>
	/// Record that this (AccountId, IpAddressId) tuple was seen, i.e. update LastSeen
	/// </summary>
	void RecordSeen();
}
