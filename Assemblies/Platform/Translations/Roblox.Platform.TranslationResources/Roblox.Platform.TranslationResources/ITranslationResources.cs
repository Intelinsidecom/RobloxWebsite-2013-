using System.Collections.Generic;

namespace Roblox.TranslationResources;

public interface ITranslationResources
{
	/// <summary>
	/// Get state of translated resources.
	/// </summary>
	/// <returns><see cref="T:Roblox.TranslationResources.TranslationResourceState" /></returns>
	TranslationResourceState State { get; }

	/// <summary>
	/// Get all keys for translated resources.
	/// </summary>
	/// <returns>Dictionary of key and values</returns>
	IReadOnlyDictionary<string, string> GetAllKeys();

	/// <summary>
	/// Get full namespace
	/// </summary>
	/// <returns>full namespace where resource is.</returns>
	string GetFullContentNamespaceName();
}
