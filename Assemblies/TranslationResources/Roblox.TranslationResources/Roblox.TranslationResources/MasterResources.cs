using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources;

public class MasterResources : IMasterResources
{
	private readonly IReadOnlyCollection<ITranslationResourcesNamespacesGroup> _TranslationResourcesNamespacesGroups;

	public IAuthenticationResources Authentication { get; }

	public ICommonResources Common { get; }

	public ICommonUIResources CommonUI { get; }

	public ICommunicationResources Communication { get; }

	public IFeatureResources Feature { get; }

	public IPurchasingResources Purchasing { get; }

	public INotificationsResources Notifications { get; }

	public IModerationResources Moderation { get; }

	public MasterResources(TranslationResourceLocale locale, TranslationResourceState state)
		: this(new AuthenticationResources(locale, state), new CommonResources(locale, state), new CommonUIResources(locale, state), new CommunicationResources(locale, state), new FeatureResources(locale, state), new PurchasingResources(locale, state), new NotificationsResources(locale, state), new ModerationResources(locale, state))
	{
	}

	internal MasterResources(IAuthenticationResources authentication, ICommonResources common, ICommonUIResources commonUi, ICommunicationResources communication, IFeatureResources feature, IPurchasingResources purchasing, INotificationsResources notifications, IModerationResources moderation)
	{
		Authentication = authentication ?? throw new ArgumentNullException("authentication");
		Common = common ?? throw new ArgumentNullException("common");
		CommonUI = commonUi ?? throw new ArgumentNullException("commonUi");
		Communication = communication ?? throw new ArgumentNullException("communication");
		Feature = feature ?? throw new ArgumentNullException("feature");
		Purchasing = purchasing ?? throw new ArgumentNullException("purchasing");
		Notifications = notifications ?? throw new ArgumentNullException("notifications");
		Moderation = moderation ?? throw new ArgumentNullException("moderation");
		_TranslationResourcesNamespacesGroups = (IReadOnlyCollection<ITranslationResourcesNamespacesGroup>)(object)new ITranslationResourcesNamespacesGroup[8] { authentication, common, commonUi, communication, feature, purchasing, notifications, moderation };
	}

	public ITranslationResources GetTranslationResourcesByFullNamespace(string fullTranslationResourceNamespace)
	{
		foreach (ITranslationResourcesNamespacesGroup translationResourcesNamespacesGroup in _TranslationResourcesNamespacesGroups)
		{
			ITranslationResources translationResources = translationResourcesNamespacesGroup.GetByFullNamespace(fullTranslationResourceNamespace);
			if (translationResources != null)
			{
				return translationResources;
			}
		}
		return null;
	}
}
