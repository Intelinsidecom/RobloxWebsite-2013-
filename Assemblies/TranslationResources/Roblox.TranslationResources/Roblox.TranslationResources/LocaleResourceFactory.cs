using System;
using System.Collections.Concurrent;

namespace Roblox.TranslationResources;

/// <summary>
/// Resource factory get resources.
/// </summary>
public class LocaleResourceFactory : ILocaleResourceFactory
{
	private readonly ConcurrentDictionary<Tuple<TranslationResourceLocale, TranslationResourceState>, IMasterResources> _MasterResources;

	public LocaleResourceFactory()
	{
		_MasterResources = new ConcurrentDictionary<Tuple<TranslationResourceLocale, TranslationResourceState>, IMasterResources>();
	}

	/// <summary>
	/// Get resource by supported locale and translation resource state
	/// </summary>
	/// <param name="locale"><see cref="T:Roblox.TranslationResources.TranslationResourceLocale" /></param>
	/// <param name="state"><see cref="T:Roblox.TranslationResources.TranslationResourceState" /></param>
	/// <returns><see cref="T:Roblox.TranslationResources.IMasterResources" /></returns>
	public IMasterResources GetMasterResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return _MasterResources.GetOrAdd(Tuple.Create(locale, state), (Tuple<TranslationResourceLocale, TranslationResourceState> key) => CreateMasterResources(key.Item1, key.Item2));
	}

	private IMasterResources CreateMasterResources(TranslationResourceLocale supportedLocaleEnum, TranslationResourceState translationResourceState)
	{
		return new MasterResources(supportedLocaleEnum, translationResourceState);
	}
}
