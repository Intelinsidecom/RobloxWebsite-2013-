namespace Roblox.Platform.IpAddresses;

public enum RbxIpCookieModeEnum
{
	/// <summary>
	/// Only use "rbx-ip" cookie
	/// </summary>
	Legacy,
	/// <summary>
	/// Keep using "rbx-ip" short-circuit logic, but start writing "rbx-ip2" cookie
	/// </summary>
	Transition,
	/// <summary>
	/// Only use "rbx-ip2" cookie
	/// </summary>
	RbxIp2
}
