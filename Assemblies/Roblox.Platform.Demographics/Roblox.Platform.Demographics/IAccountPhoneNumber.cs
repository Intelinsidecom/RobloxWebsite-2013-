using System;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents the platform object for <see cref="T:Roblox.Platform.Demographics.Entities.AccountPhoneNumberCAL" />.
/// </summary>
public interface IAccountPhoneNumber
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	int Id { get; }

	/// <summary>
	/// Gets the account identifier for this phone. Shouldn't be exposed to users under 13.
	/// </summary>
	long AccountId { get; }

	/// <summary>
	/// Gets the full phone number including the international prefix.
	/// </summary>
	string FullPhoneNumber { get; }

	/// <summary>
	/// Gets the full phone number including the international prefix and the exit code symbol (+).
	/// </summary>
	string E164PhoneNumber { get; }

	/// <summary>
	/// Gets the country code of the phone number prefix.
	/// </summary>
	string CountryCode { get; }

	/// <summary>
	/// Gets the international prefix portion of the full phone number.
	/// </summary>
	string Prefix { get; }

	/// <summary>
	/// Legacy field holding the phone number.
	/// </summary>
	[Obsolete("Use FullPhoneNumber instead")]
	string Phone { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" />'s identifier.
	/// </summary>
	/// <value>The phone number identifier.</value>
	int PhoneNumberId { get; }

	/// <summary>
	/// Tells whether the phone is verified
	/// </summary>
	bool IsVerified { get; }

	/// <summary>
	/// Tells whether the phone is active
	/// </summary>
	bool IsActive { get; }

	/// <summary>
	/// Gets the created date.
	/// </summary>
	/// <value>
	/// The created.
	/// </value>
	DateTime Created { get; }

	/// <summary>
	/// Gets the updated date.
	/// </summary>
	/// <value>
	/// The updated.
	/// </value>
	DateTime Updated { get; }

	/// <summary>
	/// Sets the account phone number to be verified.
	/// </summary>
	/// <param name="user">The user who owns the account.</param>
	/// <param name="actorUserIdentifier">The user who set it to be verified.</param>
	void SetToVerified(IUser user, IUserIdentifier actorUserIdentifier);
}
