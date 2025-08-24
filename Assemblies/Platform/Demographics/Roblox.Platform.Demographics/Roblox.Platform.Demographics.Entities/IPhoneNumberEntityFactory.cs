using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics.Entities;

internal interface IPhoneNumberEntityFactory : IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberEntity" /> with the given ID, or null if none existed.</returns>
	IPhoneNumberEntity Get(int id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberEntity" /> with the given value
	/// </summary>
	IPhoneNumberEntity GetByValue(string value);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberEntity" /> with the given value
	/// </summary>
	IPhoneNumberEntity GetOrCreate(string value);

	/// <summary>
	/// Gets or creates the <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberEntity" />
	/// </summary>
	/// <param name="value">The full phone number.</param>
	/// <param name="prefixId">The id of the <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix" /></param>
	/// <param name="nationalNumber">The portion of the phone number excluding the internal prefix.</param>
	IPhoneNumberEntity GetOrCreate(string value, short prefixId, string nationalNumber);

	/// <summary>
	/// Gets multiple <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberEntity">IPhoneNumberEntities</see> by their ids.
	/// </summary>
	ICollection<IPhoneNumberEntity> MultiGet(ICollection<int> ids);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberEntity" />s by national phone number.
	/// </summary>
	/// <param name="nationalPhoneNumber">The national phone number.</param>
	/// <param name="count">The maximum number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive start identifier.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	///     Thrown if <paramref name="count" /> is non-positive.
	///     Thrown if <paramref name="nationalPhoneNumber" /> is null or whitespace.
	/// </exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberEntity" />s.</returns>
	ICollection<IPhoneNumberEntity> GetByNationalPhoneNumberEnumerative(string nationalPhoneNumber, int count, int? exclusiveStartId = null);
}
