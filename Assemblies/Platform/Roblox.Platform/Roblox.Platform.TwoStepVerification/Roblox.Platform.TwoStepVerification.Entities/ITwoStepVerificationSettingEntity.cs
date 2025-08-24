using Roblox.Entities;

namespace Roblox.Platform.TwoStepVerification.Entities;

internal interface ITwoStepVerificationSettingEntity : IUpdateableEntity<long>, IEntity<long>
{
	bool IsEnabled { get; set; }

	long UserId { get; set; }

	byte? TwoStepVerificationMediaTypeId { get; set; }
}
