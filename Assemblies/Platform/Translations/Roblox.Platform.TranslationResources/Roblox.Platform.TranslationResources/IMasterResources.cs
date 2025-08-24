namespace Roblox.TranslationResources;

public interface IMasterResources
{
	IAuthenticationResources Authentication { get; }

	ICommonResources Common { get; }

	ICommonUIResources CommonUI { get; }

	ICommunicationResources Communication { get; }

	IFeatureResources Feature { get; }

	IPurchasingResources Purchasing { get; }

	INotificationsResources Notifications { get; }

	IModerationResources Moderation { get; }

	ITranslationResources GetTranslationResourcesByFullNamespace(string fullTranslationResourceNamespace);
}
