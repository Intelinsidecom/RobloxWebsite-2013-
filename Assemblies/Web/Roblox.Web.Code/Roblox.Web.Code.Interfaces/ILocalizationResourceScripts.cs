using Roblox.TranslationResources;

namespace Roblox.Web.Code.Interfaces;

public interface ILocalizationResourceScripts
{
	/// <summary>
	/// Check if language resource is already present in the concurrent dictionary. 
	/// If its already present, file path is taken from the dictionary and added to the PpageScripts.
	/// If its not present, a new file is created by calling and dictionary is updated.
	/// </summary>
	/// <param name="resource">Language Resource - an instance of implementation of ITranslationResources</param>
	string GetScriptFileForResource(ITranslationResources resource);
}
