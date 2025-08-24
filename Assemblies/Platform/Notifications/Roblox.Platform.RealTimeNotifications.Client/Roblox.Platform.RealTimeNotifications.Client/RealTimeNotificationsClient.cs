using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.RealTimeNotifications.Client.Properties;
using Roblox.RequestContext;

namespace Roblox.RealTimeNotifications.Client;

public class RealTimeNotificationsClient : IRealTimeNotificationsClient
{
	private readonly IServiceRequestSender _ServiceRequestSender;

	public RealTimeNotificationsClient(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader = null)
		: this(new Roblox.Http.ServiceClient.HttpClientBuilder(Settings.Default, counterRegistry, apiKeyGetter, null, requestContextLoader), Settings.Default)
	{
	}

	public RealTimeNotificationsClient(IHttpClientBuilder httpClientBuilder, IServiceClientSettings serviceClientSettings)
	{
		if (httpClientBuilder == null)
		{
			throw new ArgumentNullException("httpClientBuilder");
		}
		if (serviceClientSettings == null)
		{
			throw new ArgumentNullException("serviceClientSettings");
		}
		IHttpClient httpClient = httpClientBuilder.Build();
		HttpRequestBuilder httpRequestBuilder = new HttpRequestBuilder(serviceClientSettings.Endpoint);
		_ServiceRequestSender = new ServiceRequestSender(httpClient, httpRequestBuilder);
	}

	public PublishUserNotificationResult PublishUserNotification(long userId, JObject message, string notificationNamespace)
	{
		PublishUserNotificationRequest requestData = new PublishUserNotificationRequest
		{
			UserId = userId,
			Message = message,
			NotificationNamespace = notificationNamespace
		};
		return _ServiceRequestSender.SendPostRequest<PublishUserNotificationRequest, PublishUserNotificationResult>("/v1/PublishUserNotification", requestData);
	}

	public Task<PublishUserNotificationResult> PublishUserNotificationAsync(long userId, JObject message, string notificationNamespace, CancellationToken cancellationToken)
	{
		PublishUserNotificationRequest requestData = new PublishUserNotificationRequest
		{
			UserId = userId,
			Message = message,
			NotificationNamespace = notificationNamespace
		};
		return _ServiceRequestSender.SendPostRequestAsync<PublishUserNotificationRequest, PublishUserNotificationResult>("/v1/PublishUserNotification", requestData, cancellationToken);
	}

	public MultiPublishUserNotificationResult MultiPublishUserNotification(IReadOnlyList<long> userIds, JObject message, string notificationNamespace)
	{
		MultiPublishUserNotificationRequest requestData = new MultiPublishUserNotificationRequest
		{
			UserIds = userIds,
			Message = message,
			NotificationNamespace = notificationNamespace
		};
		return _ServiceRequestSender.SendPostRequest<MultiPublishUserNotificationRequest, MultiPublishUserNotificationResult>("/v1/MultiPublishUserNotification", requestData);
	}

	public Task<MultiPublishUserNotificationResult> MultiPublishUserNotificationAsync(IReadOnlyList<long> userIds, JObject message, string notificationNamespace, CancellationToken cancellationToken)
	{
		MultiPublishUserNotificationRequest requestData = new MultiPublishUserNotificationRequest
		{
			UserIds = userIds,
			Message = message,
			NotificationNamespace = notificationNamespace
		};
		return _ServiceRequestSender.SendPostRequestAsync<MultiPublishUserNotificationRequest, MultiPublishUserNotificationResult>("/v1/MultiPublishUserNotification", requestData, cancellationToken);
	}

	public PublishUserNotificationResult PublishBulkUserNotification(long userId, ICollection<JObject> messages, string notificationNamespace)
	{
		PublishBulkUserNotificationRequest requestData = new PublishBulkUserNotificationRequest
		{
			UserId = userId,
			Messages = messages.ToArray(),
			NotificationNamespace = notificationNamespace
		};
		return _ServiceRequestSender.SendPostRequest<PublishBulkUserNotificationRequest, PublishUserNotificationResult>("/v1/PublishBulkUserNotification", requestData);
	}

	public Task<PublishUserNotificationResult> PublishBulkUserNotificationAsync(long userId, ICollection<JObject> messages, string notificationNamespace, CancellationToken cancellationToken)
	{
		PublishBulkUserNotificationRequest requestData = new PublishBulkUserNotificationRequest
		{
			UserId = userId,
			Messages = messages.ToArray(),
			NotificationNamespace = notificationNamespace
		};
		return _ServiceRequestSender.SendPostRequestAsync<PublishBulkUserNotificationRequest, PublishUserNotificationResult>("/v1/PublishBulkUserNotification", requestData, cancellationToken);
	}
}
