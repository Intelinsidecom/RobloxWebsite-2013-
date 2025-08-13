using System;

namespace Roblox.Platform.AssetOwnership;

public class TransferStatusInvalidException : Exception
{
	public TransferStatusInvalidException()
	{
	}

	public TransferStatusInvalidException(string message)
		: base(message)
	{
	}
}
