using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents an interface for creating and retrieving an <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" />.
/// </summary>
public interface IAccountPhoneNumberFactory
{
	/// <summary>
	/// Adds a phone number for the user which then needs to be verified.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> owning the phone number.</param>
	/// <param name="simplePhoneNumber">The phone number of the user.</param>
	/// <param name="actorUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> adding the phone number.</param>
	[Obsolete("Use CreateNew(IUser user, string internationalPrefixNumber, string nationalNumber, string twoLetterCountryCode) instead")]
	IAccountPhoneNumber AddUnverifiedForUser(IUser user, string simplePhoneNumber, IUser actorUser);

	/// <summary>
	/// Adds a phone number for the user which then needs to be verified.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> owning the phone number.</param>
	/// <param name="internationalPrefixNumber">The <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix">international prefix</see> portion (aka "country code") of a phone number when dialing to this number from another country (eg. "1" for America, "44" for the United Kingdoms, "1" for Canada).</param>
	/// <param name="nationalNumber">The national number portion of a phone number, which (usually) begins with the area code and does not include the long-distance dialing prefix (eg the national part of American phone numbers would be 10 digits starting with the 3-digit area code, does not include with the "1" prefix for dialing long distance).</param>
	/// <param name="twoLetterCountryCode">The standard two-letter code denoting the <see cref="T:Roblox.Platform.Demographics.ICountry">country/region/territory</see> for the phone number (eg. "US", "GB", "CA").</param>
	/// <param name="actorUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> adding the phone number.</param>
	IAccountPhoneNumber AddUnverifiedForUser(IUser user, string internationalPrefixNumber, string nationalNumber, string twoLetterCountryCode, IUser actorUser);

	/// <summary>
	/// Adds a phone number for the user which then needs to be verified.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> owning the phone number.</param>
	/// <param name="phoneNumber">The phone number of the user.</param>
	/// <param name="actorUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> adding the phone number.</param>
	IAccountPhoneNumber AddUnverifiedForUser(IUser user, IPhoneNumber phoneNumber, IUser actorUser);

	/// <summary>
	/// Obtains the most recently verified phone number for the user
	/// </summary>
	IAccountPhoneNumber GetVerifiedForUser(IUser user);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> to be verified by account identifier.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>The to-be-verified <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> associated with the passed in account Id if exists or null otherwise.
	/// Returns null if the latest IAccountPhoneNumber is already verified.</returns>
	IAccountPhoneNumber GetPendingVerificationPhoneNumber(IUser user);

	/// <summary>
	/// Get the <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> for a given phone number id.
	/// </summary>
	/// <param name="phoneNumberIdentifier">The phone number identifier <see cref="T:Roblox.Platform.Demographics.IPhoneNumberIdentifier" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">If any of the params is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformInvalidPhoneNumberException">If the phone is invalid.</exception>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> or null if there wasn't one.</returns>
	IAccountPhoneNumber GetByPhoneNumber(IPhoneNumberIdentifier phoneNumberIdentifier);

	/// <summary>
	/// Get the <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> for a given phone.
	/// </summary>
	/// <param name="target">The target phone number, which consists of an international number prefix, a national number and a two letter country code</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">If the param is null or empty</exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformInvalidPhoneNumberException">If the phone is invalid</exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformPhoneNotFoundException">If the phone wasn't found</exception>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> or null if there wasn't one</returns>
	IAccountPhoneNumber GetByPhoneNumber(string target);

	/// <summary>
	/// Get the <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> for a given phone.
	/// </summary>
	/// <param name="internationalPrefixNumber">The <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix">international prefix</see> portion (aka "country code") of a phone number when dialing to this number from another country (eg. "1" for America, "44" for the United Kingdoms, "1" for Canada).</param>
	/// <param name="nationalNumber">The national number portion of a phone number, which (usually) begins with the area code and does not include the long-distance dialing prefix (eg the national part of American phone numbers would be 10 digits starting with the 3-digit area code, does not include with the "1" prefix for dialing long distance).</param>
	/// <param name="twoLetterCountryCode">The standard two-letter code denoting the <see cref="T:Roblox.Platform.Demographics.ICountry">country/region/territory</see> for the phone number (eg. "US", "GB", "CA").</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">If any of the params is null or empty</exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformInvalidPhoneNumberException">If the phone is invalid</exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformPhoneNotFoundException">If the phone wasn't found</exception>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> or null if there wasn't one</returns>
	IAccountPhoneNumber GetByPhoneNumber(string internationalPrefixNumber, string nationalNumber, string twoLetterCountryCode);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> by <paramref name="phoneNumberIdentifier" />.
	/// </summary>
	/// <param name="phoneNumberIdentifier">The <see cref="T:Roblox.Platform.Demographics.IPhoneNumberIdentifier" />.</param>
	/// <param name="isVerified">Whether the phone number has been verified by the account holder.</param>
	/// <param name="isActive">Whether the phone number is active.</param>
	/// <param name="count">Maximum number of <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> to get.</param>
	/// <param name="exclusiveStartId">The exclusive start identifier.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="phoneNumberIdentifier" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is not positive.</exception>
	/// <returns>A page of <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" /> or an empty list if none are found.</returns>
	ICollection<IAccountPhoneNumber> GetByPhoneNumberIsVerifiedAndIsActive(IPhoneNumberIdentifier phoneNumberIdentifier, bool isVerified, bool isActive, int count, int? exclusiveStartId = null);

	/// <summary>
	/// Deletes the user's saved phone number.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="actorUser">The actor <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="exclusiveStartId">The start id to not delete from.</param>
	/// <returns>If the number was deleted succesfully</returns>
	bool DeletePhoneNumberForUser(IUser user, IUser actorUser, int? exclusiveStartId = null);

	/// <summary>
	/// Purge the user's current phone number and phone number history from our data stores. Intended for compliance with data privacy laws such as COPPA.
	/// </summary>
	/// <param name="user"></param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="user" /> is null</exception>
	void PurgePhoneNumber(IUser user);

	/// <summary>
	/// Checks if an account phone number can be added.
	/// </summary>
	/// <param name="phoneNumberId">The phone number id/&gt;.</param>
	/// <returns>If the account phone number can be added</returns>
	bool DoesPhoneNumberAlreadyExist(int phoneNumberId);

	/// <summary>
	/// Sends a revert phone number email
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="accountEmailAddress">The <see cref="T:Roblox.AccountEmailAddress" />.</param>
	/// <returns>If the email is sent, false otherwise</returns>
	bool SendRevertPhoneNumberEmail(IUser user, AccountEmailAddress accountEmailAddress);

	/// <summary>
	/// Returns a formatted phone number from the country code and phone
	/// </summary>
	/// <param name="phone">The phone number/&gt;.</param>
	/// <param name="countryCode">The country code/&gt;.</param>
	/// <param name="numberOfVisibleDigits">The number of digits we're displaying/&gt;.</param>
	/// <param name="maskCharacter">The character that we mask with/&gt;.</param>
	/// <returns>The formatted phone number</returns>
	string GetMaskedAndFormattedPhoneNumberString(string phone, string countryCode, int numberOfVisibleDigits = 4, char maskCharacter = '*');
}
