namespace Roblox.Platform.AssetOwnership;

public class TransferResult
{
	public TransferStatus TransferStatus { get; set; }

	public string Message { get; set; }

	public TransferResult(TransferStatus transferStatus, string message)
	{
		TransferStatus = transferStatus;
		Message = message;
	}
}
