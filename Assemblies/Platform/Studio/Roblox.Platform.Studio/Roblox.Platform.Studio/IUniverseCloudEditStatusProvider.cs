namespace Roblox.Platform.Studio;

/// <summary>
/// Provides possibility to get or update a CloudEditStatus for specified universe 
/// </summary>
public interface IUniverseCloudEditStatusProvider
{
	/// <summary>
	/// Returns cloud edit enabled status for corresponding universe.
	/// </summary>
	/// <param name="universeID">ID of universe</param>
	/// <returns>null in case when property doesn't exist, true or false - if enabled or not correspondingly</returns>
	bool? IsCloudEditEnabled(long universeID);

	/// <summary>
	/// Updates CloudEditEnabled status for specified universe
	/// </summary>
	/// <param name="universeID"></param>
	/// <param name="isCloudEditEnabled"></param>
	void UpdateCloudEditStatus(long universeID, bool isCloudEditEnabled);
}
