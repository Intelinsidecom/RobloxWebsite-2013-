using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;
using Roblox.Amazon.Sqs;
using Roblox.Properties;

namespace Roblox;

public static class FileUploadEventPublisher
{
	private static SqsBatchSender _BatchSender;

	static FileUploadEventPublisher()
	{
		Settings.Default.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			if ((args.PropertyName == "FileManagerAwsAccessKeyAndAwsSecretAccessKey" || args.PropertyName == "FileManagerAmazonSqsUrl") && _BatchSender != null)
			{
				_BatchSender.Stop();
				_BatchSender = null;
			}
		};
	}

	public static void PublishToSqs(string hash, string contentType, int verifyRetryCount = 0, int uploadRetryCount = 0, bool reverify = false, int messageDelayInSeconds = 0, string format = null)
	{
		LazyInitializer.EnsureInitialized(ref _BatchSender, delegate
		{
			string[] array = Settings.Default.FileManagerPublisherAwsAccessKeyAndAwsSecretAccessKey.Split(',');
			string awsAccessKey = array[0];
			string awsSecretKey = array[1];
			SqsBatchSender sqsBatchSender = new SqsBatchSender(awsAccessKey, awsSecretKey, Settings.Default.FileManagerAmazonSqsUrl, 10, 100, messageDelayInSeconds, retryInOtherRegions: true);
			sqsBatchSender.ExceptionOccured += ExceptionHandler.LogException;
			sqsBatchSender.Start();
			return sqsBatchSender;
		});
		PublishToSqs(new TransferFileTask
		{
			Hash = hash,
			ContentType = contentType,
			VerifyRetryCount = verifyRetryCount,
			UploadRetryCount = uploadRetryCount,
			VerifyOnly = reverify,
			Format = format
		});
	}

	public static void PublishToSqs(TransferFileTask task)
	{
		string message = JsonConvert.SerializeObject(task);
		_BatchSender.SendMessage(message);
	}
}
