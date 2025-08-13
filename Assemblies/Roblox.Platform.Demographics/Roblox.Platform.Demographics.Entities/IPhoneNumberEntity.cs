using Roblox.Entities;

namespace Roblox.Platform.Demographics.Entities;

internal interface IPhoneNumberEntity : IUpdateableEntity<int>, IEntity<int>
{
	string Value { get; set; }

	short? PhoneNumberInternationalPrefixId { get; set; }

	string NationalPhoneNumber { get; set; }

	bool? IsBlacklisted { get; set; }
}
