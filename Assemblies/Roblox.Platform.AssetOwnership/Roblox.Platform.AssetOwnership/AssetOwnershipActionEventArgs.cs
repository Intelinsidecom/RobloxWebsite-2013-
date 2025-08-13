using System;

namespace Roblox.Platform.AssetOwnership;

public class AssetOwnershipActionEventArgs : EventArgs
{
	public string Action { get; }

	public Exception Exception { get; set; }

	public long RequestId { get; }

	public string Result { get; set; }

	public AssetOwnershipActionEventArgs(string action, long requestId)
	{
		Action = action;
		RequestId = requestId;
	}
}
