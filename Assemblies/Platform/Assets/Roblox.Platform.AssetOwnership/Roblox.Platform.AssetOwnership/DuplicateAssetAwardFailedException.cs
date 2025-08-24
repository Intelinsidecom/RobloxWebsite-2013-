using System;

namespace Roblox.Platform.AssetOwnership;

public class DuplicateAssetAwardFailedException : ApplicationException
{
	public DuplicateAssetAwardFailedException()
	{
	}

	public DuplicateAssetAwardFailedException(string message)
		: base(message)
	{
	}
}
