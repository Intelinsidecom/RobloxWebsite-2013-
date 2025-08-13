using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Social.Properties;
using Roblox.Properties;

namespace Roblox.Platform.Social.Follow;

internal class FollowPrivacySettingFactory : IFollowPrivacySettingFactory
{
	private readonly FollowDomainFactories _DomainFactories;

	[ExcludeFromCodeCoverage]
	internal virtual FollowPrivacyType _DefaultPrivacyTypeForOver13User => (FollowPrivacyType)Roblox.Properties.Settings.Default.DefaultFollowPrivacySetting;

	[ExcludeFromCodeCoverage]
	internal virtual FollowPrivacyType _DefaultPrivacyTypeForUnder13User => (FollowPrivacyType)Roblox.Platform.Social.Properties.Settings.Default.DefaultUnder13FollowPrivacySetting;

	public FollowPrivacySettingFactory(FollowDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
	}

	public IFollowPrivacySetting GetOrCreate(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		FollowPrivacyType defaultPrivacySetting = ((user.AgeBracket == Roblox.Platform.Membership.AgeBracket.Age13OrOver) ? _DefaultPrivacyTypeForOver13User : _DefaultPrivacyTypeForUnder13User);
		IUserFollowPrivacySettingEntity entity = _DomainFactories.FollowPrivacySettingEntityFactory.GetOrCreate(user.Id, (byte)defaultPrivacySetting);
		return new FollowPrivacySetting(_DomainFactories, user, (FollowPrivacyType)entity.FollowPrivacyTypeId, _DefaultPrivacyTypeForUnder13User, _DefaultPrivacyTypeForOver13User);
	}
}
