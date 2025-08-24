using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Email.User;

/// <summary>
/// Factory for loading the e-mail information associated with an <see cref="T:Roblox.Platform.Membership.IUser" />.
///
/// Future direction - replace with an IUserEmailFactory abstraction
/// </summary>
public interface IAccountEmailAddressFactory
{
	/// <summary>
	/// GetAccountsByEmailAddress the <see cref="T:Roblox.Platform.Email.User.IAccountEmail" /> associated with the given <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> whose e-mail we are looking up.</param>
	/// <returns>A <see cref="T:Roblox.Platform.Email.User.IAccountEmail" /> or null if not found.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">No user provided</exception>
	IAccountEmail Get(IUser user);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Email.User.IAccountEmail" />s by email address.
	/// </summary>
	/// <param name="address">The email address.</param>
	/// <param name="count">The count.</param>
	/// <param name="exclusiveStartId">The exclusive start identifier. </param>
	/// <returns>
	/// A collection of <see cref="T:Roblox.Platform.Email.User.IAccountEmail" />s, if any.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">address
	/// or
	/// exclusiveStartId
	/// or
	/// count</exception>
	ICollection<IAccountEmail> GetAccountsByEmailAddress(string address, int count, int exclusiveStartId = 0);

	/// <summary>
	/// Gets the active <see cref="T:Roblox.Platform.Email.User.IAccountEmail" />s by email address.
	/// </summary>
	/// <param name="emailAddress">The email address.</param>
	/// <param name="count">The count.</param>
	/// <param name="exclusiveStartId">The exclusive start identifier.</param>
	/// <returns>
	/// A collection of <see cref="T:Roblox.Platform.Email.User.IAccountEmail" />s, if any.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">address
	/// or
	/// exclusiveStartId
	/// or
	/// count</exception>
	ICollection<IAccountEmail> GetCurrentAccountsByEmailAddress(string emailAddress, int count, int exclusiveStartId = 0);

	/// <summary>
	/// Gets the active <see cref="T:Roblox.Platform.Email.User.IAccountEmail" />s by email address.
	/// </summary>
	/// <param name="emailAddress">The email address.</param>
	/// <param name="isVerified">Whether or not to retrieve the verified <see cref="T:Roblox.Platform.Email.User.IAccountEmail" /> only.</param>
	/// <param name="count">The count.</param>
	/// <param name="exclusiveStartId">The exclusive start identifier.</param>
	/// <returns>A collection of <see cref="T:Roblox.Platform.Email.User.IAccountEmail" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	///     Thrown if <paramref name="emailAddress" /> is null or whitespace 
	///     or if <paramref name="count" /> is less or equal than default value
	///     or if <paramref name="exclusiveStartId" />'s value if any is less than default value
	/// </exception>
	ICollection<IAccountEmail> GetCurrentEmailAccountsByEmailAddressIsVerified(string emailAddress, bool isVerified, int count, int? exclusiveStartId = null);
}
