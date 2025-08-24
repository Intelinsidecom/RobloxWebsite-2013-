using System;
using Roblox.Platform.Studio.Entities;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Studio;

/// <summary>
/// Provides possibility to get or update a CloudEditStatus for specified universe 
/// </summary>
public class UniverseCloudEditStatusProvider : IUniverseCloudEditStatusProvider
{
	private readonly IUniverseFactory _UniverseFactory;

	/// <summary>
	/// Main constructor
	/// </summary>
	/// <param name="universeFactory">Instance of IUniverseFactory</param>
	public UniverseCloudEditStatusProvider(IUniverseFactory universeFactory)
	{
		if (universeFactory == null)
		{
			throw new ArgumentNullException("universeFactory");
		}
		_UniverseFactory = universeFactory;
	}

	/// <summary>
	/// Returns cloud edit enabled status for corresponding universe.
	/// </summary>
	/// <param name="universeID">ID of universe</param>
	/// <returns>null in case when property doesn't exist, true or false - if enabled or not correspondingly</returns>
	public bool? IsCloudEditEnabled(long universeID)
	{
		return UniverseCloudEditStatus.GetByUniverseID(universeID)?.IsEnabled;
	}

	/// <summary>
	/// Updates CloudEditEnabled status for specified universe
	/// </summary>
	/// <param name="universeID"></param>
	/// <param name="isCloudEditEnabled"></param>
	/// <exception cref="T:Roblox.Platform.Universes.UnknownUniverseException">Thrown when universe with provided id is not exists</exception>
	public void UpdateCloudEditStatus(long universeID, bool isCloudEditEnabled)
	{
		UniverseCloudEditStatus orCreate = UniverseCloudEditStatus.GetOrCreate((_UniverseFactory.GetUniverse(universeID) ?? throw new UnknownUniverseException(universeID)).Id);
		orCreate.IsEnabled = isCloudEditEnabled;
		orCreate.Save();
	}
}
