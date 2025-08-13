namespace Roblox.Web.Code.Economy;

public interface IRobuxIconPermissionVerifier
{
	/// <summary>
	/// Checks if new Robux icon is enabled for current user
	/// </summary>
	/// <returns>bool</returns>
	bool IsNewRobuxIconEnabled();
}
