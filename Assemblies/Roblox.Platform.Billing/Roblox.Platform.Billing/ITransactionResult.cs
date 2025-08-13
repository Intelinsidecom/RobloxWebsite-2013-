namespace Roblox.Platform.Billing;

public interface ITransactionResult
{
	bool IsSuccess { get; set; }

	ISale Sale { get; set; }
}
