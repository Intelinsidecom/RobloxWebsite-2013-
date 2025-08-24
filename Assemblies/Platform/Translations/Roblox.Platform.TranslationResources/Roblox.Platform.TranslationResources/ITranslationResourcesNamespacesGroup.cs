namespace Roblox.TranslationResources;

/// <summary>
/// A translation namespace.
/// </summary>
public interface ITranslationResourcesNamespacesGroup
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.TranslationResources.ITranslationResources" /> by full namespace string.
	/// </summary>
	/// <param name="fullTranslationResourceNamespace">The full translation resource namespace.</param>
	/// <returns>An <see cref="T:Roblox.TranslationResources.ITranslationResources" /> (or <c>null</c> if it does not exist in the this <see cref="T:Roblox.TranslationResources.ITranslationResourcesNamespacesGroup" />.)</returns>
	/// <exception cref="T:System.ArgumentException"><paramref name="fullTranslationResourceNamespace" /> is null or whitespace.</exception>
	ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace);
}
