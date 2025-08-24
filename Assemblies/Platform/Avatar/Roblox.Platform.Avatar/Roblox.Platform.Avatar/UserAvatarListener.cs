using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Listens for events that GetOrCreate UserAvatars and clear Thumbnails
/// </summary>
public class UserAvatarListener : IUserAvatarListener
{
	private readonly IUserAvatarFactory _UserAvatarFactory;

	private readonly IAccoutrementFactory _AccoutrementFactory;

	public UserAvatarListener(IUserAvatarFactory userAvatarFactory, IAccoutrementFactory accoutrementFactory)
	{
		_UserAvatarFactory = userAvatarFactory ?? throw new PlatformArgumentNullException("userAvatarFactory");
		_AccoutrementFactory = accoutrementFactory ?? throw new PlatformArgumentNullException("accoutrementFactory");
	}

	public void Unregister()
	{
		UserAvatar.EntityClearThumbnail -= OnUserAvatarClearThumbnail;
		UserAvatar.EntityUserAssetRemoved -= OnUserAssetRemoved;
	}

	public void Register()
	{
		UserAvatar.EntityClearThumbnail += OnUserAvatarClearThumbnail;
		UserAvatar.EntityUserAssetRemoved += OnUserAssetRemoved;
	}

	private void OnUserAvatarClearThumbnail(long userId)
	{
		if (userId <= 0)
		{
			throw new PlatformArgumentException("userId");
		}
		_UserAvatarFactory.GetOrCreate(userId).ClearThumbnail();
	}

	private void OnUserAssetRemoved(long userAssetId, long userId)
	{
		if (userId <= 0)
		{
			throw new PlatformArgumentException("userId");
		}
		IAccoutrement accoutrement = _AccoutrementFactory.GetByUserAssetID(userAssetId);
		if (accoutrement != null)
		{
			accoutrement.Delete();
			UserAvatar.InvokeClearThumbnailEvent(userId);
		}
	}
}
