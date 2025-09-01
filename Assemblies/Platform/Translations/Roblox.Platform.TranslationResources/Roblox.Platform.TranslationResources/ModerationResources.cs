using System;
using System.Collections.Generic;
using Roblox.Platform.TranslationResources.Moderation;
namespace Roblox.Platform.TranslationResources {
    class ModerationResources : IModerationResources, ITranslationResourcesNamespacesGroup

{
	private readonly Lazy<IModeratorActionsResources> _IModeratorActionsResources;

	public IModeratorActionsResources ModeratorActions => _IModeratorActionsResources.Value;

	public ModerationResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		_IModeratorActionsResources = new Lazy<IModeratorActionsResources>(() => ModeratorActionsResourceFactory.GetResources(locale, state));
	}

	public ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace)
	{
		if (string.IsNullOrWhiteSpace(fullTranslationResourceNamespace))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "fullTranslationResourceNamespace");
		}
		if (fullTranslationResourceNamespace == "Moderation.ModeratorActions")
		{
			return ModeratorActions;
		}
		return null;
	}
}


}

