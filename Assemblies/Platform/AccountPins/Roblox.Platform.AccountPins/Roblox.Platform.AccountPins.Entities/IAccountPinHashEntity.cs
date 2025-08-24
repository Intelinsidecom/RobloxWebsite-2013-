using Roblox.Entities;
using Roblox.Platform.AccountPins.Entities.Audit;

namespace Roblox.Platform.AccountPins.Entities;

/// <summary>
/// An interface for holding the Pin entry entity.
/// </summary>
/// <seealso cref="T:Roblox.Entities.IUpdateableEntity`1" />
internal interface IAccountPinHashEntity : IUpdateableEntity<long>, IEntity<long>
{
	/// <summary>
	/// Gets or sets the account identifier.
	/// </summary>
	/// <value>
	/// The account identifier.
	/// </value>
	long AccountId { get; set; }

	/// <summary>
	/// Gets or sets the pin hash.
	/// </summary>
	/// <value>
	/// The pin hash.
	/// </value>
	string PinHash { get; set; }

	/// <summary>
	/// Returns true if ... is valid.
	/// </summary>
	/// <value>
	///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
	/// </value>
	bool IsValid { get; set; }

	IAccountPinHashesAuditEntity BuildAuditEntity(AccountPinsDomainFactories domainFactories);
}
