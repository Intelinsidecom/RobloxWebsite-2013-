using System.Diagnostics.CodeAnalysis;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsReceiptFactory" />.
/// </summary>
[ExcludeFromCodeCoverage]
public class SqsReceiptFactory : ISqsReceiptFactory
{
	/// <summary>
	/// <inheritdoc cref="M:Roblox.Amazon.Sqs.ISqsReceiptFactory.GetSqsReceipt(System.String,System.String)" />
	/// </summary>
	public ISqsReceipt GetSqsReceipt(string receiptHandle, string regionName)
	{
		return new SqsReceipt
		{
			ReceiptHandle = receiptHandle,
			RegionName = regionName
		};
	}
}
