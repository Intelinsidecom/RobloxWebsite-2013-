using System.Collections.Generic;

namespace Roblox.Platform.Membership.Entities;

public interface IAccountEntityFactory
{
	/// <summary>
	/// Gets the account entity of the specified account id.
	/// </summary>
	/// <returns>Returns null if no account is found with the given id.</returns>
	IAccountEntity GetAccount(long id);

	/// <summary>
	/// Gets the account entity of the specified account name.
	/// </summary>
	/// <returns>Returns null if no account is found with the given name.</returns>
	IAccountEntity GetAccount(string name);

	/// <summary>
	/// Gets the account entity of the specified account id.  Will not return null.
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Account data not available (caught DataIntegrityException from the callstack beneath).</exception>
	IAccountEntity MustGetAccount(long id);

	/// <summary>
	/// Gets a collection of accounts of the specified ids.
	/// </summary>
	ICollection<IAccountEntity> GetAccounts(ICollection<long> ids);
}
