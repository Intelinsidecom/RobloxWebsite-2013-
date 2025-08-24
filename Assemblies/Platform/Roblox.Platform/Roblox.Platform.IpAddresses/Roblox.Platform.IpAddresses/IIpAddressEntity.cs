using System;
using Roblox.Entities;

namespace Roblox.Platform.IpAddresses;

/// <summary>
/// An IP address from which someone at some point accessed Roblox
/// </summary>
public interface IIpAddressEntity : IUpdateableEntity<int>, IEntity<int>
{
	/// <summary>
	/// Whether this IP is banned for website access
	/// </summary>
	State State { get; set; }

	/// <summary>
	/// Expiration date of any ban
	/// </summary>
	DateTime? Expiration { get; set; }

	/// <summary>
	/// String value of the IP eg: 127.0.0.1
	/// </summary>
	string Value { get; set; }
}
