using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Social.Follow.Entities;

[ExcludeFromCodeCoverage]
internal class UserFollowPrivacySettingCachedMssqlEntity : IUserFollowPrivacySettingEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long UserId { get; set; }

	public byte FollowPrivacyTypeId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		UserFollowPrivacySetting cal = UserFollowPrivacySetting.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.UserID = UserId;
		cal.FollowPrivacyTypeID = (FollowPrivacyType)FollowPrivacyTypeId;
		cal.Save();
		Updated = cal.Updated;
	}

	[Obsolete("Required to satisfy an interface. Not inteded to be used, just set to NoOne.")]
	public void Delete()
	{
		throw new InvalidOperationException("Cannot be deleted, try update instead");
	}
}
