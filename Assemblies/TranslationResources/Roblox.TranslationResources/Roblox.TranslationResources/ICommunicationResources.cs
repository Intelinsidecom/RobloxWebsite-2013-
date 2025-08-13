using Roblox.TranslationResources.Communication;

namespace Roblox.TranslationResources;

public interface ICommunicationResources : ITranslationResourcesNamespacesGroup
{
	ICommonEmailResources CommonEmail { get; }
}
