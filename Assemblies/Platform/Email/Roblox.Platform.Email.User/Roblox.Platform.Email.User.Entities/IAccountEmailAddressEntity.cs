using Roblox.Entities;

namespace Roblox.Platform.Email.User.Entities;

internal interface IAccountEmailAddressEntity : IUpdateableEntity<int>, IEntity<int>
{
	long AccountId { get; }

	int EmailAddressId { get; }

	bool IsVerified { get; set; }

	bool IsValid { get; set; }

	bool NewsLetter { get; set; }
}
