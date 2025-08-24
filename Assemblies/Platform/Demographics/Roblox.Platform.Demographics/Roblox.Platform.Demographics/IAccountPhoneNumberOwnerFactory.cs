using System.Collections.Generic;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that produces <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberOwner" />es.
/// </summary>
public interface IAccountPhoneNumberOwnerFactory
{
	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberOwner" /> by phone number value.
	/// </summary>
	/// <param name="phoneNumberValue">The phone number value in E164 format.</param>
	/// <param name="isVerified">Whether the phone number has been verified by the account holder.</param>
	/// <param name="isActive">Whether the phone number is active</param>
	/// <param name="count">Maximum number of <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberOwner" /> to get</param>
	/// <param name="exclusiveStartId">The exclusive start identifier</param>
	/// <returns>
	///     A page of <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberOwner" /> associated with the <paramref name="phoneNumberValue" />
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	///     Thrown if <paramref name="count" /> was not positive
	///     Thrown if <paramref name="phoneNumberValue" /> was null or whitespace
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformInvalidPhoneNumberException">
	///     Thrown if the <paramref name="phoneNumberValue" /> is not valid or properly formatted
	/// </exception>
	ICollection<IAccountPhoneNumberOwner> GetAccountPhoneNumberOwnersByPhoneNumberValueIsVerifiedAndIsActive(string phoneNumberValue, bool isVerified, bool isActive, int count, int? exclusiveStartId = null);

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberOwner" /> by phone number identifier.
	/// </summary>
	/// <param name="phoneNumberId">The <see cref="T:Roblox.Platform.Demographics.IPhoneNumberIdentifier" />.</param>
	/// <param name="isVerified">Whether the phone number has been verified by the account holder.</param>
	/// <param name="isActive">Whether the phone number is active</param>
	/// <param name="count">Maximum number of <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberOwner" /> to get</param>
	/// <param name="exclusiveStartId">The exclusive start identifier</param>
	/// <returns>
	///     A page of <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberOwner" /> associated with the <paramref name="phoneNumberId" />
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	///     Thrown if <paramref name="count" /> was not positive
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     Thrown if <paramref name="phoneNumberId" /> was null
	/// </exception>
	ICollection<IAccountPhoneNumberOwner> GetAccountPhoneNumberOwnersByPhoneNumberIdIsVerifiedAndIsActive(IPhoneNumberIdentifier phoneNumberId, bool isVerified, bool isActive, int count, int? exclusiveStartId = null);
}
