using System.Diagnostics.CodeAnalysis;
using Amazon.SQS;

namespace Roblox.Amazon.Sqs;

[ExcludeFromCodeCoverage]
internal class BatchDeleterFactory : IBatchDeleterFactory
{
	public ISqsBatchDeleter GetBatchDeleter(IAmazonSQS sqsClient, string sqsUrl, ISqsPerformanceMonitor totalPerformanceMonitor, ISqsPerformanceMonitor regionPerformanceMonitor)
	{
		SqsBatchDeleter sqsBatchDeleter = new SqsBatchDeleter(sqsClient, sqsUrl, totalPerformanceMonitor, regionPerformanceMonitor);
		sqsBatchDeleter.Start();
		return sqsBatchDeleter;
	}
}
