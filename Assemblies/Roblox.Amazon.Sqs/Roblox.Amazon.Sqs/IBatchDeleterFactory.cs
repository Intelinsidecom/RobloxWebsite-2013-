using Amazon.SQS;

namespace Roblox.Amazon.Sqs;

internal interface IBatchDeleterFactory
{
	ISqsBatchDeleter GetBatchDeleter(IAmazonSQS sqsClient, string sqsUrl, ISqsPerformanceMonitor totalPerformanceMonitor, ISqsPerformanceMonitor regionPerformanceMonitor);
}
