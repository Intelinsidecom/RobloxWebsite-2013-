namespace Roblox.Amazon.Sqs;

/// <summary>
/// A factory object that is capable of creating AWS <seealso cref="T:Roblox.Amazon.Sqs.ISqsReceipt" />.
/// </summary>
public interface ISqsReceiptFactory
{
	/// <summary>
	/// Create and return the Sqs receipt based on the input.
	/// </summary>
	/// <param name="receiptHandle">The handle string of the receipt.</param>
	/// <param name="regionName">The regional system name of the receipt that is received from.</param>
	/// <returns>An <see cref="T:Roblox.Amazon.Sqs.ISqsReceipt" />.</returns>
	ISqsReceipt GetSqsReceipt(string receiptHandle, string regionName);
}
