using System;

namespace Roblox;

public interface IUserAvatar
{
	int ID { get; }

	long UserID { get; }

	long NewAvatarAssetHashID { get; set; }

	string AvatarHash { get; set; }

	DateTime Created { get; }

	DateTime Updated { get; }

	long? BodyColorSetID { get; set; }

	byte? PlayerAvatarTypeID { get; set; }

	int? ScaleID { get; set; }

	void ClearThumbnail();

	void Save();
}
