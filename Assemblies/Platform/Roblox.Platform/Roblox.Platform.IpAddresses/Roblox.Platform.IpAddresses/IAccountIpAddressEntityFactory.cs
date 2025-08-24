using System;
using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.IpAddresses;

public interface IAccountIpAddressEntityFactory : IDomainFactory<IpAddressDomainFactories>, IDomainObject<IpAddressDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" /> with the given ID, or null if none existed.</returns>
	IAccountIpAddressEntity Get(long id);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" /> with the given accountId and ipAddressId.
	/// </summary>
	/// <param name="accountId">The Account id</param>
	/// <param name="ipAddressId">The IpAddress id</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="accountId" /> or <paramref name="ipAddressId" /> is non-positive.</exception>
	/// <returns>The <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" /> with the given characterisics.</returns>
	IAccountIpAddressEntity GetOrCreate(long accountId, long ipAddressId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s by their TODO: Fill in.
	/// </summary>
	/// <param name="accountId">Account to fetch Ips for</param>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="accountId" /> or <paramref name="maxRows" /> is non-positive.</exception>
	/// TODO: Add other exceptions
	/// <returns>The page of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s.</returns>
	IEnumerable<IAccountIpAddressEntity> GetByAccountIdPaged(long accountId, int startRowIndex, int maxRows);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s for the given accountId.
	/// </summary>
	/// <param name="accountId">The accountId</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="accountId" /> is non-positive.</exception>
	/// <returns>The total number of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s with the given accountId</returns>
	long GetTotalByAccountId(long accountId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s by their ipAddress id.
	/// </summary>
	/// <param name="ipAddressId">The IpAddress id</param>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> or <paramref name="ipAddressId" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s.</returns>
	IEnumerable<IAccountIpAddressEntity> GetByIpAddressIdPaged(long ipAddressId, int startRowIndex, int maxRows);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s with the given ip address
	/// </summary>
	/// <param name="ipAddressId">The IpAddress id</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="ipAddressId" /> is non-positive.</exception>
	/// <returns>The total number of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s with the given  ip address.</returns>
	long GetTotalByIpAddressId(long ipAddressId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s by their account ID.
	/// </summary>
	/// <param name="accountId">The account ID to fetch entities for.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartLastSeen">Exclusive key at which to begin getting entities.
	/// Expected to have DateTimeKind.Utc.</param>
	/// <param name="exclusiveStartID">Exclusive key at which to begin getting entities that match exclusiveStartLastSeen.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> or <paramref name="exclusiveStartID" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.IpAddresses.IAccountIpAddressEntity" />s.</returns>
	ICollection<IAccountIpAddressEntity> GetByAccountIdEnumerative(long accountId, int count, DateTime? exclusiveStartLastSeen = null, long? exclusiveStartID = null);
}
