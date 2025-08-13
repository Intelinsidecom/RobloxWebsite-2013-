using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that wraps a phone number.
/// </summary>
public interface IPhoneNumber : IPhoneNumberIdentifier, IDomainObjectIdentifier<int>
{
	/// <summary>
	/// Gets the phone number's value.
	/// </summary>
	/// <value>
	/// The phone number's value.
	/// </value>
	[Obsolete("Use FullPhoneNumber instead.")]
	string Value { get; }

	/// <summary>
	/// The identifier of the <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix" />.
	/// </summary>
	IPhoneNumberInternationalPrefixIdentifier InternationalPrefixIdentifier { get; }

	IPhoneNumberInternationalPrefix InternationalPrefix { get; }

	/// <summary>
	/// The full phone number including the international prefix.
	/// </summary>
	string FullPhoneNumber { get; }

	/// <summary>
	/// The national phone number portion which excludes the international prefix.
	/// </summary>
	string NationalPhoneNumber { get; }

	/// <summary>
	/// Whether we should avoid contacting this phone number.
	/// </summary>
	bool IsBlacklisted { get; }

	void SetIsBlacklisted(bool isBlacklisted);

	/// <summary>
	/// Gets the current phone number in E164 format.
	/// </summary>
	/// <returns></returns>
	string GetPhoneNumberInE164Format();
}
