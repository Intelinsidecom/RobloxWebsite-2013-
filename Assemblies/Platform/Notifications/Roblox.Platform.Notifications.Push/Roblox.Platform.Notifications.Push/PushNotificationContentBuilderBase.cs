using Newtonsoft.Json;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.TranslationResources;

namespace Roblox.Platform.Notifications.Push;

public abstract class PushNotificationContentBuilderBase<TNotification, TDetail> : IPushNotificationContentBuilder, INotificationBuilder where TNotification : INotification
{
	private const string _StandardTitle = "ROBLOX";

	private readonly ILocalizationResourceProvider _LocalizationResourceProvider;

	public abstract NotificationSourceType NotificationSourceType { get; }

	public PushNotificationContentBuilderBase(ILocalizationResourceProvider localizationResourceProvider)
	{
		_LocalizationResourceProvider = localizationResourceProvider;
	}

	public PushNotificationContentBuilderBase()
	{
	}

	public ISilentNewContentPushNotification BuildSilentNewContentPushNotification(string notificationJson)
	{
		TNotification notification = JsonConvert.DeserializeObject<TNotification>(notificationJson);
		TDetail detail = BuildDetail(notification);
		return new SilentNewContentPushNotification
		{
			NotificationType = NotificationSourceType,
			EventDate = notification.EventDate,
			Detail = detail,
			Category = BuildCategory(detail)
		};
	}

	public IVisibleNewContentPushNotification BuildVisibleNewContentPushNotification(IUser user, string notificationJson)
	{
		TNotification notification = JsonConvert.DeserializeObject<TNotification>(notificationJson);
		TDetail detail = BuildDetail(notification);
		return new VisibleNewContentPushNotification
		{
			NotificationType = NotificationSourceType,
			EventDate = notification.EventDate,
			Detail = detail,
			Category = BuildCategory(detail),
			Title = BuildTitle(detail),
			Body = ((user == null) ? BuildBody(detail) : BuildLocalizedBody(user, detail))
		};
	}

	protected IMasterResources GetLocalizationResourcesFromUser(IUser user)
	{
		return _LocalizationResourceProvider?.GetLocalizationResources(user);
	}

	protected abstract string BuildCategory(TDetail detail);

	protected abstract TDetail BuildDetail(TNotification notification);

	protected abstract string BuildBody(TDetail detail);

	protected abstract string BuildLocalizedBody(IUser user, TDetail detail);

	protected virtual string BuildTitle(TDetail detail)
	{
		return "ROBLOX";
	}
}
