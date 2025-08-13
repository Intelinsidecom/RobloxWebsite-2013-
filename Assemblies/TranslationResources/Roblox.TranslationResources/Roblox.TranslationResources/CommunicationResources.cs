using System;
using Roblox.TranslationResources.Communication;

namespace Roblox.TranslationResources;

internal class CommunicationResources : ICommunicationResources, ITranslationResourcesNamespacesGroup
{
	private readonly Lazy<ICommonEmailResources> _ICommonEmailResources;

	public ICommonEmailResources CommonEmail => _ICommonEmailResources.Value;

	public CommunicationResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		_ICommonEmailResources = new Lazy<ICommonEmailResources>(() => CommonEmailResourceFactory.GetResources(locale, state));
	}

	public ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace)
	{
		if (string.IsNullOrWhiteSpace(fullTranslationResourceNamespace))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "fullTranslationResourceNamespace");
		}
		if (fullTranslationResourceNamespace == "Communication.CommonEmail")
		{
			return CommonEmail;
		}
		return null;
	}
}
