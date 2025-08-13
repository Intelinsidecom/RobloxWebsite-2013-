using System;

namespace Roblox.Platform.AssetOwnership;

public class UserAssetDisappearedException : Exception
{
	public UserAssetDisappearedException()
	{
	}

	public UserAssetDisappearedException(string message)
		: base(message)
	{
	}
}
