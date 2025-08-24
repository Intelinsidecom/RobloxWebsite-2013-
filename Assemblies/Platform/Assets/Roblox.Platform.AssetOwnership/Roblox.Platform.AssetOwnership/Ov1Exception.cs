using System;

namespace Roblox.Platform.AssetOwnership;

internal class Ov1Exception : Exception
{
	public Ov1Exception()
	{
	}

	public Ov1Exception(string message)
		: base(message)
	{
	}
}
