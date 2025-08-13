using System;
using System.Net;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Push.Entities;

namespace Roblox.Platform.Notifications.Push;

internal class MozillaPushServiceClient : IPushServiceClient
{
	private readonly ILogger _Logger;

	private readonly TimeSpan _MessageTimeToLive = TimeSpan.FromDays(14.0);

	public MozillaPushServiceClient(ILogger logger)
	{
		_Logger = logger;
	}

	public string GetDevicePushPublishEndpoint(IDestinationTypeEntity destinationType, string deviceToken, string nativeEndpoint)
	{
		return nativeEndpoint;
	}

	public PublishNotificationResult PublishNotificationToDestination(string endpoint, string jsonMessage)
	{
		HttpWebRequest obj = WebRequest.Create(endpoint) as HttpWebRequest;
		obj.Method = "POST";
		obj.Headers.Add("TTL", ((int)_MessageTimeToLive.TotalSeconds).ToString());
		HttpWebResponse response = (HttpWebResponse)obj.GetResponse();
		switch (response.StatusCode)
		{
		case HttpStatusCode.OK:
		case HttpStatusCode.Created:
			return new PublishNotificationResult(PublishNotificationStatus.Published);
		case HttpStatusCode.Gone:
			return new PublishNotificationResult(PublishNotificationStatus.DestinationExpired);
		default:
			throw new PushDeliveryException($"Push Delivery to Mozilla Push Service Failed. Status Code: {(int)response.StatusCode}");
		}
	}
}
