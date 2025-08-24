using System;

namespace Roblox.Platform.AssetOwnership;

/// <summary>
/// When the dual write returns a result indicating that the transaction failed in the primary write target (probably ov1)
/// </summary>
public class Ov1Ov2TransactionException : Exception
{
	public Ov1Ov2TransactionException()
	{
	}

	public Ov1Ov2TransactionException(string message)
		: base(message)
	{
	}
}
