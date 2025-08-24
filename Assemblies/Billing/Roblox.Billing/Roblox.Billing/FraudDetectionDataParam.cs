namespace Roblox.Billing;

internal class FraudDetectionDataParam
{
	public string UserName { get; set; }

	public Sale Sale { get; set; }

	public string SessionId { get; set; }

	public PaymentInfo PaymentInfo { get; set; }

	public string TransactionId { get; set; }

	public decimal TransactionAmount { get; set; }

	public TransactionStatus TranactionStatus { get; set; }
}
