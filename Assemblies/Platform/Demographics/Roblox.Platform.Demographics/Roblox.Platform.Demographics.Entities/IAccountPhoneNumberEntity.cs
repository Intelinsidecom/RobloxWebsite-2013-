using Roblox.Entities;

namespace Roblox.Platform.Demographics.Entities;

internal interface IAccountPhoneNumberEntity : IUpdateableEntity<int>, IEntity<int>
{
	long AccountId { get; set; }

	string Phone { get; set; }

	int? PhoneNumberId { get; set; }

	bool? IsVerified { get; set; }

	bool? IsActive { get; set; }
}
