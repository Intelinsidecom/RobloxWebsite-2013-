using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.AccountPins.Entities;

internal interface IAccountPinHashEntityFactory : IDomainFactory<AccountPinsDomainFactories>, IDomainObject<AccountPinsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AccountPins.Entities.IAccountPinHashEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AccountPins.Entities.IAccountPinHashEntity" /> with the given ID, or null if none existed.</returns>
	IAccountPinHashEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.AccountPins.Entities.IAccountPinHashEntity" />s by their TODO: Fill in.
	/// </summary>
	/// <param name="accountId">The account identifier.</param>
	/// <param name="isValid">if set to <c>true</c> [is valid].</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.</param>
	/// <returns>
	/// The page of <see cref="T:Roblox.Platform.AccountPins.Entities.IAccountPinHashEntity" />s.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	IEnumerable<IAccountPinHashEntity> GetByAccountIdAndIsValidEnumerative(long accountId, bool isValid, int count, long? exclusiveStartId = null);

	/// <summary>
	/// Creates the new <see cref="T:Roblox.Platform.AccountPins.Entities.IAccountPinHashEntity" />.
	/// </summary>
	/// <param name="accountId">The account identifier.</param>
	/// <param name="hash">The hash.</param>
	/// <returns></returns>
	IAccountPinHashEntity CreateNew(long accountId, string hash);

	/// <summary>
	/// Gets the valid <see cref="T:Roblox.Platform.AccountPins.Entities.IAccountPinHashEntity" /> if present.
	/// </summary>
	/// <param name="accountId">The account identifier.</param>
	/// <returns>An <see cref="T:Roblox.Platform.AccountPins.Entities.IAccountPinHashEntity" /> if present or returns null.</returns>
	IAccountPinHashEntity GetValid(long accountId);
}
