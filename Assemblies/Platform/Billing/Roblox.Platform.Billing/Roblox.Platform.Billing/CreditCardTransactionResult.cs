namespace Roblox.Platform.Billing;

internal class CreditCardTransactionResult : ITransactionResult
{
	public bool IsSuccess { get; set; }

	public ISale Sale { get; set; }

	internal CreditCardTransactionResult(bool isSuccess, ISale sale)
	{
		IsSuccess = isSuccess;
		Sale = sale;
	}
}
