namespace Roblox.Billing;

/// <summary>
/// Represents proof of purchase from the Amazon store.
/// </summary>
public class AmazonStoreProofOfPurchase
{
	/// <summary>
	/// Roblox Account ID
	/// </summary>
	public long AccountId { get; set; }

	/// <summary>
	/// Gets the ID of the receipt provided by Amazon.
	/// </summary>
	public string AmazonReceiptId { get; set; }

	/// <summary>
	/// Gets the ID of the amazon user performing the purchase.
	/// </summary>
	public string AmazonUserId { get; set; }

	/// <summary>
	/// Gets the Amazon product ID.
	/// </summary>
	public string AmazonProductId { get; set; }

	/// <summary>
	/// Gets or sets the date that a product subscription was canceled.
	/// If a substriction is ongoing then <see cref="P:Roblox.Billing.AmazonStoreProofOfPurchase.CancelDate" /> will be null.
	/// </summary>
	public string CancelDate { get; set; }

	/// <summary>
	/// Gets the date on which the product was purchased.
	/// </summary>
	public long? PurchaseDate { get; set; }

	/// <summary>
	/// Gets or sets the type of product that was purchased.
	/// </summary>
	public string ProductType { get; set; }

	/// <summary>
	/// Gets or sets whether or not the transaction is a test transaction.
	/// </summary>
	public bool IsTestTransaction { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Billing.AmazonStoreProofOfPurchase" /> class.
	/// </summary>
	/// <param name="receiptId">The ID of the receipt provided by Amazon.</param>
	/// <param name="amazonUserId">The ID of the amazon user performing the purchase.</param>
	/// <param name="verificationClient">Verification Client to override (test purpose)</param>
	public AmazonStoreProofOfPurchase(long accountId, string receiptId, string amazonUserId)
	{
		AccountId = accountId;
		AmazonReceiptId = receiptId;
		AmazonUserId = amazonUserId;
	}
}
