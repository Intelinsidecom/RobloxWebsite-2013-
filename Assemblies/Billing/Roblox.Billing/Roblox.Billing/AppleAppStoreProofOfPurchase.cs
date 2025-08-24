namespace Roblox.Billing;

public class AppleAppStoreProofOfPurchase
{
	public enum AppleAppStorePaymentStatusType
	{
		Success,
		Failure,
		Error
	}

	public bool IsVerified => Status == 0;

	public long AccountId { get; set; }

	public string AppItemId { get; set; }

	public string Bid { get; set; }

	public string BVRS { get; set; }

	public int Status { get; set; }

	public string ItemId { get; set; }

	public string OriginalPurchaseDate { get; set; }

	public string OriginalTransactionId { get; set; }

	public string ProductId { get; set; }

	public string PurchaseDate { get; set; }

	public string Quantity { get; set; }

	public string Receipt { get; set; }

	public string TransactionId { get; set; }

	public string VersionExternalIdentifier { get; set; }

	internal AppleAppStoreProofOfPurchase(string receipt, long accountId)
	{
		AccountId = accountId;
		Receipt = receipt;
		Status = 2;
	}
}
