namespace Roblox.Platform.Assets;

/// <summary>
/// Interface for validating that a User has access to a given Asset.
/// </summary>
public interface IAccessChecker
{
	bool HasAccess(IAsset asset, User user);
}
