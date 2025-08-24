namespace Roblox.Platform.StaticContent;

/// <summary>
/// Gets the component suffix to load static content from.
/// </summary>
public interface IComponentSuffixProvider
{
	/// <summary>
	/// Gets the component suffix.
	/// </summary>
	/// <returns></returns>
	string GetComponentSuffix();
}
