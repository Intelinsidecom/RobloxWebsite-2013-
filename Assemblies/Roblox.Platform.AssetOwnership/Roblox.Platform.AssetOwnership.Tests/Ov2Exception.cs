using System;

namespace Roblox.Platform.AssetOwnership.Tests;

internal class Ov2Exception : Exception
{
	public Ov2Exception()
	{
	}

	public Ov2Exception(string message)
		: base(message)
	{
	}
}
