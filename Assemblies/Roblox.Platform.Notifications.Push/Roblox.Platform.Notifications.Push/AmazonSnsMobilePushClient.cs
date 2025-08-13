using System;
using System.Net;
using Amazon;
using Amazon.Runtime;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Roblox.Amazon.Sns;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Push.Entities;
using Roblox.Platform.Notifications.Push.Properties;

namespace Roblox.Platform.Notifications.Push;

internal class AmazonSnsMobilePushClient : IPushServiceClient
{
	private readonly ILogger _Logger;

	private IAmazonSimpleNotificationService _SnsClient;

	private readonly IRobloxSnsClientFactory _ClientFactory;

	private bool _Disposed;

	private const string _JsonMessageStructure = "json";

	public const string _GuidFormat = "N";

	private readonly object _Lock = new object();

	public AmazonSnsMobilePushClient(ILogger logger)
	{
		_Logger = logger;
		_ClientFactory = RobloxSnsClientFactory.Instance;
		_ClientFactory.DefaultClientSettingsChanged += OnSnsClientDefaultSettingsChange;
		Settings.Default.PropertyChanged += delegate
		{
			lock (_Lock)
			{
				_SnsClient = null;
			}
		};
	}

	private void OnSnsClientDefaultSettingsChange(RobloxSnsClientDefaultSettings defaultSettings)
	{
		lock (_Lock)
		{
			_SnsClient = null;
		}
	}

	public string GetDevicePushPublishEndpoint(IDestinationTypeEntity destinationType, string deviceToken, string nativeEndpoint)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		string applicationArn = destinationType.RegistrationEndpoint;
		return GetSnsClient().CreatePlatformEndpoint(new CreatePlatformEndpointRequest
		{
			PlatformApplicationArn = applicationArn,
			Token = deviceToken
		}).EndpointArn;
	}

	public PublishNotificationResult PublishNotificationToDestination(string endpoint, string jsonMessage)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		try
		{
			PublishResponse response = GetSnsClient().Publish(new PublishRequest
			{
				TargetArn = endpoint,
				Message = jsonMessage,
				MessageStructure = "json"
			});
			if (((AmazonWebServiceResponse)response).HttpStatusCode != HttpStatusCode.OK)
			{
				throw new PushDeliveryException($"Push Delivery to Amazon SNS Failed. Status Code: {((AmazonWebServiceResponse)response).HttpStatusCode}");
			}
			return new PublishNotificationResult(PublishNotificationStatus.Published)
			{
				Receipt = AmazonSnsMobilePushUtility.BuildNotificationPublishReceipt(Guid.Parse(response.MessageId))
			};
		}
		catch (EndpointDisabledException)
		{
			return new PublishNotificationResult(PublishNotificationStatus.DestinationExpired);
		}
	}

	private IAmazonSimpleNotificationService GetSnsClient()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		IAmazonSimpleNotificationService snsClient = _SnsClient;
		if (snsClient != null)
		{
			return snsClient;
		}
		lock (_Lock)
		{
			if (_SnsClient == null)
			{
				string[] keys = Settings.Default.SNSApplicationsAccessKeyAndSecretKey.Split(',');
				BasicAWSCredentials credentials = new BasicAWSCredentials(keys[0], keys[1]);
				_SnsClient = _ClientFactory.Create((AWSCredentials)(object)credentials, RegionEndpoint.USEast1, string.Format("Roblox{0}", "AmazonSnsMobilePushClient"));
			}
			return _SnsClient;
		}
	}

	/// <summary>
	/// Disposes the HTTP handler.
	/// </summary>
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!_Disposed)
		{
			if (_ClientFactory != null)
			{
				_ClientFactory.DefaultClientSettingsChanged -= OnSnsClientDefaultSettingsChange;
			}
			_Disposed = true;
		}
	}
}
