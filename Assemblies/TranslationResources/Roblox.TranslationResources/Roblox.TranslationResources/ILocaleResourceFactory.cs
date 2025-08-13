namespace Roblox.TranslationResources;

public interface ILocaleResourceFactory
{
	/// <summary>
	/// Get resource by supported locale and translation resource state
	/// </summary>
	/// <param name="locale"><see cref="T:Roblox.TranslationResources.TranslationResourceLocale" /></param>
	/// <param name="state"><see cref="T:Roblox.TranslationResources.TranslationResourceState" /></param>
	/// <returns><see cref="T:Roblox.TranslationResources.IMasterResources" /></returns>
	IMasterResources GetMasterResources(TranslationResourceLocale locale, TranslationResourceState state);
}
