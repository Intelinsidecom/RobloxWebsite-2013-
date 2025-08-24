using Roblox.Entities;

namespace Roblox.Platform.Social.Follow;

internal interface IUserFollowPrivacySettingEntity : IUpdateableEntity<long>, IEntity<long>
{
	long UserId { get; set; }

	byte FollowPrivacyTypeId { get; set; }
}
