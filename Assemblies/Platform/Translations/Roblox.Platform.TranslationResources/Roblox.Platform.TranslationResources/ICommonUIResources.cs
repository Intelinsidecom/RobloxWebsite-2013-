using Roblox.TranslationResources.CommonUI;

namespace Roblox.TranslationResources;

public interface ICommonUIResources : ITranslationResourcesNamespacesGroup
{
	IControlsResources Controls { get; }

	IFeaturesResources Features { get; }

	IMessagesResources Messages { get; }
}
