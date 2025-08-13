using Roblox.Common;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

internal class UserAvatarFactory : IUserAvatarFactory
{
	private readonly AvatarDomainFactories _AvatarDomainFactories;

	public UserAvatarFactory(AvatarDomainFactories avatarDomainFactories)
	{
		_AvatarDomainFactories = avatarDomainFactories ?? throw new PlatformArgumentNullException("avatarDomainFactories");
	}

	public IUserAvatar Get(int id)
	{
		return UserAvatar.Get(id);
	}

	public IUserAvatar GetOrCreate(long userId, byte? playerAvatarTypeId = null, int? scaleId = null)
	{
		if (userId <= 0)
		{
			throw new PlatformArgumentException("userId");
		}
		if (!playerAvatarTypeId.HasValue)
		{
			playerAvatarTypeId = (byte?)EnumUtils.StrictTryParseEnum<PlayerAvatarType>(Settings.Default.DefaultPlayerAvatarType);
		}
		if (!scaleId.HasValue)
		{
			scaleId = _AvatarDomainFactories.OutfitDomainFactories.ScaleFactory.GetDefault().Id;
		}
		return UserAvatar.GetOrCreate(userId, playerAvatarTypeId, scaleId);
	}
}
