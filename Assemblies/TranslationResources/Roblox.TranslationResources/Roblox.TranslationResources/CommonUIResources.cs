using System;
using Roblox.TranslationResources.CommonUI;

namespace Roblox.TranslationResources;

internal class CommonUIResources : ICommonUIResources, ITranslationResourcesNamespacesGroup
{
	private readonly Lazy<IControlsResources> _IControlsResources;

	private readonly Lazy<IFeaturesResources> _IFeaturesResources;

	private readonly Lazy<IMessagesResources> _IMessagesResources;

	public IControlsResources Controls => _IControlsResources.Value;

	public IFeaturesResources Features => _IFeaturesResources.Value;

	public IMessagesResources Messages => _IMessagesResources.Value;

	public CommonUIResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		_IControlsResources = new Lazy<IControlsResources>(() => ControlsResourceFactory.GetResources(locale, state));
		_IFeaturesResources = new Lazy<IFeaturesResources>(() => FeaturesResourceFactory.GetResources(locale, state));
		_IMessagesResources = new Lazy<IMessagesResources>(() => MessagesResourceFactory.GetResources(locale, state));
	}

	public ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace)
	{
		if (string.IsNullOrWhiteSpace(fullTranslationResourceNamespace))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "fullTranslationResourceNamespace");
		}
		return fullTranslationResourceNamespace switch
		{
			"CommonUI.Controls" => Controls, 
			"CommonUI.Features" => Features, 
			"CommonUI.Messages" => Messages, 
			_ => null, 
		};
	}
}
