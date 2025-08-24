namespace Roblox.TranslationResources;

/// <summary>
/// Base class for all resource implementation classes.
/// </summary>
public class TranslationResourcesBase
{
	/// <summary>
	/// Get state of translated resources.
	/// </summary>
	/// <returns><see cref="T:Roblox.TranslationResources.TranslationResourceState" /></returns>  
	public TranslationResourceState State { get; }

	protected TranslationResourcesBase(TranslationResourceState state)
	{
		State = state;
	}
}
