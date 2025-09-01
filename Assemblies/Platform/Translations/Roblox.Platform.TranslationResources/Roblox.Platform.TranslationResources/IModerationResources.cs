using System;
using System.Collections.Generic;
using Roblox.Platform.TranslationResources.Moderation;
namespace Roblox.Platform.TranslationResources {
    public interface IModerationResources : ITranslationResourcesNamespacesGroup

{
	IModeratorActionsResources ModeratorActions { get; }
}


}


