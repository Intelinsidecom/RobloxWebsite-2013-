using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Gigya;

/// <summary>
/// Provides a common interface for a Gigya User.
/// </summary>
public interface IGigyaUser : IGigyaValidatable
{
	/// <summary>
	/// The Gigya UID for this user.
	/// </summary>
	new string UID { get; }

	/// <summary>
	/// The first name for this user.
	/// </summary>
	string FirstName { get; }

	/// <summary>
	/// The nickname for this user.
	/// </summary>
	string Nickname { get; }

	/// <summary>
	/// The birthday for this user.
	/// </summary>
	DateTime? Birthday { get; }

	/// <summary>
	/// The gender for this user.
	/// </summary>
	GenderType Gender { get; }

	/// <summary>
	/// The email for this user.
	/// </summary>
	string Email { get; }

	/// <summary>
	/// The photo URL for this user.
	/// </summary>
	string PhotoUrl { get; }

	GigyaProviderType LoginProvider { get; }

	/// <summary>
	/// The provider specific UID for this user.
	/// </summary>
	string LoginProviderUID { get; }

	/// <summary>
	/// A list of <see cref="T:Roblox.Gigya.IGigyaIdentity" />s for this user.
	/// </summary>
	ICollection<IGigyaIdentity> Identities { get; }
}
