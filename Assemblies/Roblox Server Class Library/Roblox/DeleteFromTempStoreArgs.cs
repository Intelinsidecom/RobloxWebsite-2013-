using System;

namespace Roblox;

public class DeleteFromTempStoreArgs : EventArgs
{
	public string FileHash;

	public DateTime TransferredTime;
}
