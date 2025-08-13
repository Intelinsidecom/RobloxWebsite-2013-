namespace Roblox.Platform.Infrastructure;

public interface IServerValidator
{
	/// <summary>
	/// Given an IP address will return the known <see cref="T:Roblox.Platform.Infrastructure.ServerType" /> for it.
	/// </summary>
	/// <param name="ipAddress">The IP addresss.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Infrastructure.ServerType" /> (or <c>null</c> if the IP address/<see cref="T:Roblox.Platform.Infrastructure.ServerType" /> is unknown.)</returns>
	ServerType? GetServerTypeByIpAddress(string ipAddress);

	/// <summary>
	/// Similar to <see cref="M:Roblox.Platform.Infrastructure.IServerValidator.GetServerTypeByIpAddress(System.String)" /> but does not try to parse the value into the enum (<see cref="T:Roblox.Platform.Infrastructure.ServerType" />).
	/// </summary>
	/// <remarks>
	/// Useful for debugging to figure out if the server has an invalid server type ID.
	/// </remarks>
	/// <param name="ipAddress">The IP addresss.</param>
	/// <returns>Returns the stored ServerTypeID for the server (or <c>null</c> if the IP address is invalid).</returns>
	int? GetServerTypeIdByIpAddress(string ipAddress);

	/// <summary>
	/// Gets the server status for a given IP address.
	/// </summary>
	/// <param name="ipAddress">The IP addresss.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Infrastructure.ServerStatus" /> (or <c>null</c> if the IP address/<see cref="T:Roblox.Platform.Infrastructure.ServerStatus" /> is unknown).</returns>
	ServerStatus? GetServerStatusByIpAddress(string ipAddress);

	/// <summary>
	/// Similar to <see cref="M:Roblox.Platform.Infrastructure.IServerValidator.GetServerStatusByIpAddress(System.String)" /> but does not try to parse the value into the enum (<see cref="T:Roblox.Platform.Infrastructure.ServerStatus" />).
	/// </summary>
	/// <remarks>
	/// Useful for debugging to figure out if the server has an invalid status type ID.
	/// </remarks>
	/// <param name="ipAddress">The IP addresss.</param>
	/// <returns>Returns the stored ServerStatusID for the server (or <c>null</c> if the IP address is invalid).</returns>
	int? GetServerStatusIdByIpAddress(string ipAddress);

	/// <summary>
	/// Verifies that the IP address belongs to a live game server or one of the server groups with access
	/// </summary>
	/// <param name="ipAddress">The IP addresss.</param>
	bool VerifyAccess(string ipAddress);

	/// <summary>
	/// Verifies that an input IP address belongs to a Roblox load balancer.
	/// We need to verify that extra headers on our requests (X-Forwarded-For)
	/// were added by load balancers.
	/// </summary>
	/// <param name="ipAddress">The IP addresss.</param>
	bool IsAllowedProxyIp(string ipAddress);

	/// <summary>
	/// Verifies that an input IP address belongs to a specific whitelist of IPs (proxy IPs).
	/// </summary>
	/// <remarks>
	/// Whitelist determined by <see cref="P:Roblox.Platform.Infrastructure.Properties.ISettings.WhitelistedIpAddressRanges" />.
	/// </remarks>
	/// <param name="ipAddress">The IP addresss.</param>
	bool IsWhitelistedIp(string ipAddress);

	/// <summary>
	/// Determines if the input IP address is from DosArrest.
	/// </summary>
	/// <remarks>
	/// This is used to determine
	/// if we should accept the X-Real-Ip header from the request.
	/// </remarks>
	/// <param name="ipAddress">The IP addresss.</param>
	bool IsDosArrestIp(string ipAddress);
}
