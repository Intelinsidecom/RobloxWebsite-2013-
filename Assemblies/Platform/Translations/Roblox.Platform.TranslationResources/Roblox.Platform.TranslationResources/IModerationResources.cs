using Roblox.TranslationResources.Moderation;

namespace Roblox.TranslationResources;

public interface IModerationResources : ITranslationResourcesNamespacesGroup
{
	IModeratorActionsResources ModeratorActions { get; }
}
