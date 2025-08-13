using Roblox.Entities;

namespace Roblox.Platform.Demographics.Entities;

/// <summary>
/// An interface for the PhoneNumberInternationalPrefixEntity
/// </summary>
internal interface IPhoneNumberInternationalPrefixEntity : IUpdateableEntity<short>, IEntity<short>
{
	/// <summary>
	/// The ID of the <see cref="T:Roblox.Platform.Demographics.Country" />
	/// </summary>
	int CountryId { get; set; }

	/// <summary>
	/// The international prefix
	/// </summary>
	string InternationalPrefix { get; set; }

	/// <summary>
	/// Whether this is active
	/// </summary>
	bool IsActive { get; set; }
}
