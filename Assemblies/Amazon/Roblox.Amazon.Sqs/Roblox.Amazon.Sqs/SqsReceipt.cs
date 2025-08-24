namespace Roblox.Amazon.Sqs;

/// <summary>
/// The default implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsReceipt" />.
/// </summary>
internal class SqsReceipt : ISqsReceipt
{
	/// <summary>
	/// <inheritdoc cref="P:Roblox.Amazon.Sqs.ISqsReceipt.ReceiptHandle" />
	/// </summary>
	public string ReceiptHandle { get; set; }

	/// <summary>
	/// <inheritdoc cref="P:Roblox.Amazon.Sqs.ISqsReceipt.RegionName" />
	/// </summary>
	public string RegionName { get; set; }
}
