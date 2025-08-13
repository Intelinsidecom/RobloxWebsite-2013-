using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class CatalogQueryFloodChecker : FloodChecker
{
	/// <inheritdoc />
	/// <param name="userIdentifier">ID of user (IP address can be populated as fallback)</param>
	public CatalogQueryFloodChecker(string userIdentifier)
		: base($"CatalogQueryFloodChecker_UserID:{userIdentifier}", Settings.Default.CatalogQueryFloodCheckerLimit, Settings.Default.CatalogQueryFloodCheckerExpiry)
	{
	}
}
