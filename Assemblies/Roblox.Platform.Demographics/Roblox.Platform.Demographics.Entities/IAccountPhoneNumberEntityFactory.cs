using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics.Entities;

internal interface IAccountPhoneNumberEntityFactory : IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" /> with the given ID, or null if none existed.</returns>
	IAccountPhoneNumberEntity Get(int id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" />s by their accountId and whehter they are verified.
	/// </summary>
	/// <param name="accountId">The accountId.</param>
	/// <param name="isVerified">Whether the phone number has been verified by the account holder.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartAccountPhoneNumberId">The exclusive key at which to begin getting entities.  Null grabs the first page.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" />s.</returns>
	IEnumerable<IAccountPhoneNumberEntity> GetByAccountIdAndIsVerifiedEnumerative(long accountId, bool? isVerified, int count, int? exclusiveStartAccountPhoneNumberId = null);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" />s by their accountId and whehter they are verified.
	/// </summary>
	/// <param name="accountId">The accountId.</param>
	/// <param name="isVerified">Whether the phone number has been verified by the account holder.</param>
	/// <param name="isActive">Whether the phone number is active.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartAccountPhoneNumberId">The exclusive key at which to begin getting entities.  Null grabs the first page.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" />s.</returns>
	IEnumerable<IAccountPhoneNumberEntity> GetByAccountIdIsVerifiedAndIsActiveEnumerative(long accountId, bool? isVerified, bool? isActive, int count, int? exclusiveStartAccountPhoneNumberId = null);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" />s by their account id, ordered descending by entity id
	/// </summary>
	/// <param name="accountId">The accountId.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartAccountPhoneNumberId">The exclusive key at which to begin getting entities.  Null grabs the first page.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" />s.</returns>
	IEnumerable<IAccountPhoneNumberEntity> GetByAccountIdEnumerative(long accountId, int count, long? exclusiveStartAccountPhoneNumberId = null);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" />s by their accountId and whehter they are verified.
	/// </summary>
	/// <param name="phoneNumberId">The phoneNumberId.</param>
	/// <param name="isVerified">Whether the phone number has been verified by the account holder.</param>
	/// <param name="isActive">Whether the phone number is active.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartAccountPhoneNumberId">The exclusive key at which to begin getting entities.  Null grabs the first page.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" />s.</returns>
	IEnumerable<IAccountPhoneNumberEntity> GetByPhoneNumberIDIsVerifiedAndIsActiveEnumerative(int phoneNumberId, bool? isVerified, bool? isActive, int count, int? exclusiveStartAccountPhoneNumberId = null);

	/// <summary>
	/// Creates a new account phone number entity
	/// </summary>
	/// <param name="accountId">The accountId</param>
	/// <param name="phoneNumber">The <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /></param>
	/// <returns></returns>
	IAccountPhoneNumberEntity CreateNew(long accountId, IPhoneNumber phoneNumber);
}
