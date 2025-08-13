using System;
using System.Collections.Generic;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// A factory object that is capable of getting and constructing <see cref="T:Roblox.Amazon.Sqs.ISqsConsumerWithReceipt" /> objects.
/// </summary>
public interface ISqsConsumerFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Amazon.Sqs.ISqsConsumerWithReceipt" /> with specified input parameters.
	/// </summary>
	/// <param name="sqsConfigSettings">The config settings required for setting up connections to SQS.</param>
	/// <param name="requestedMessageAttributes">The list of attributes for constructing SQS message requests.</param>
	/// <param name="performanceMonitorCategory">The performance monitor category for this consumer.</param>
	/// <param name="batchSize">The batch size for the SQS message requests.</param>
	/// <param name="visibilityTimeout">The visibility timeout for the SQS message requests.</param>
	/// <param name="waitTimeGetter">Getter for the wait time of the SQS message requests.</param>
	/// This effectively controls how soon the message will be visible again to others.
	/// <returns><see cref="T:Roblox.Amazon.Sqs.ISqsConsumerWithReceipt" /></returns>
	/// <exception cref="T:System.ArgumentNullException">Throws when sqsConfigSettings is null.</exception>
	/// <exception cref="T:System.ArgumentException">Throws when performanceMonitorCategory is null or white space.</exception>
	ISqsConsumerWithReceipt GetSqsConsumerWithReceipt(ISqsConfigSettings sqsConfigSettings, List<string> requestedMessageAttributes, string performanceMonitorCategory, int batchSize, int visibilityTimeout, Func<TimeSpan> waitTimeGetter = null);
}
