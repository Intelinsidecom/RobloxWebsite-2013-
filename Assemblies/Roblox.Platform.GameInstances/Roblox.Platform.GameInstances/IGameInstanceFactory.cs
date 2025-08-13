using System;
using System.Collections.Generic;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Devices;

namespace Roblox.Platform.GameInstances;

/// <summary>
/// An interface represents a factory that is responsible for working with <see cref="T:Roblox.Platform.GameInstances.IGameInstance" />.
/// Todo: The default implmetation of this interface needs proper unit test coverage. 
/// </summary>
public interface IGameInstanceFactory
{
	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.GameInstances.IGameInstance" />.
	/// </summary>
	/// <returns></returns>
	ICollection<IGameInstance> GetAll();

	/// <summary>
	/// Gets All game instances (including Private Server instances) in a paged fashion
	/// </summary>
	/// <param name="placeId"></param>
	/// <param name="startRowIndex"></param>
	/// <param name="maximumRows"></param>
	/// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> of <see cref="T:Roblox.Platform.GameInstances.IGameInstance" /></returns>
	ICollection<IGameInstance> GetAllPaged(long placeId, int startRowIndex, int maximumRows);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.GameInstances.IGameInstance" /> by place Id and game codes.
	/// </summary>
	/// <param name="placeId"></param>
	/// <param name="gameCodes"></param>
	/// <returns></returns>
	IReadOnlyCollection<IGameInstance> GetByPlaceAndGameCodes(long placeId, IEnumerable<Guid> gameCodes);

	/// <summary>
	/// Gets the number of game instances by the place Id.
	/// </summary>
	/// <param name="placeId"></param>
	/// <returns></returns>
	int GetCount(long placeId);

	/// <summary>
	/// Gets a game instance by place id and instance id
	/// </summary>
	/// <param name="placeId"></param>
	/// <param name="gameInstanceId"></param>
	/// <returns><see cref="T:Roblox.Platform.GameInstances.IGameInstance" /></returns>
	IGameInstance GetGameInstance(long placeId, Guid gameInstanceId);

	/// <summary>
	/// Gets gameIdentifiers in a paged fashion by universeId.  This includes private servers.
	/// </summary>
	/// <param name="universeId"></param>
	/// <param name="startRowIndex"></param>
	/// <param name="maximumRows"></param>
	/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:Roblox.Platform.GameInstances.IGameInstanceIdentifier" /></returns>
	IEnumerable<IGameInstanceIdentifier> GetGameInstanceIdentifiersByUniverse(long universeId, int startRowIndex, int maximumRows);

	/// <summary>
	/// Gets a collection of <see cref="T:Roblox.Platform.GameInstances.IGameInstance" />s by place Id and some other criteria.
	/// </summary>
	/// <param name="placeId"></param>
	/// <param name="includePrivateInstances"></param>
	/// <param name="gameCodes"></param>
	/// <param name="matchmakingContextId"></param>
	/// <param name="startRowIndex"></param>
	/// <param name="maximumRows"></param>
	/// <returns></returns>
	ICollection<IGameInstance> GetGameInstances(long placeId, bool includePrivateInstances, Guid[] gameCodes, int? matchmakingContextId, int startRowIndex, int maximumRows);

	/// <summary>
	/// Gets a collection of <see cref="T:Roblox.Platform.GameInstances.IGameInstance" />s by place Id and some other criteria.
	/// </summary>
	/// <param name="placeId"></param>
	/// <param name="includePrivateInstances"></param>
	/// <param name="gameCodes"></param>
	/// <param name="matchmakingContextId"></param>
	/// <param name="exclusiveStartKeyInfo"></param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.PlatformPageResponse`2" /> of <see cref="T:Roblox.Platform.GameInstances.IGameInstance" />s</returns>
	PlatformPageResponse<long, IGameInstance> GetGameInstances(long placeId, bool includePrivateInstances, Guid[] gameCodes, int? matchmakingContextId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	/// <summary>
	/// Gets a collection of <see cref="T:Roblox.Platform.GameInstances.IGameInstance" />s by place Id and game instance Ids.
	/// </summary>
	/// <param name="placeId"></param>
	/// <param name="gameInstanceIds"></param>
	/// <returns></returns>
	ICollection<IGameInstance> GetGameInstancesByIds(long placeId, IEnumerable<Guid> gameInstanceIds);

	/// <summary>
	/// Gets game instances (excluding Private Server instances) in a paged fashion
	/// </summary>
	/// <param name="placeId"></param>
	/// <param name="startRowIndex"></param>
	/// <param name="maximumRows"></param>
	/// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> of <see cref="T:Roblox.Platform.GameInstances.IGameInstance" /></returns>
	ICollection<IGameInstance> GetPaged(long placeId, int startRowIndex, int maximumRows);

	/// <summary>
	/// Gets place summary by place Id.
	/// </summary>
	/// <param name="placeId"></param>
	/// <returns></returns>
	IPlaceSummary GetPlaceSummary(long placeId);

	/// <summary>
	/// Gets player count by place Id.
	/// </summary>
	/// <note type="caution">
	/// This methods will take into account config settings' ExcludedMatchmakingContextIds.
	/// </note>
	/// <param name="placeId"></param>
	/// <returns></returns>
	int GetPlayerCount(long placeId);

	/// <summary>
	/// Gets player count by place Id and device type.
	/// </summary>
	/// <note type="caution">
	/// This methods will take into account config settings' ExcludedMatchmakingContextIds.
	/// </note>
	/// <param name="placeId"></param>
	/// <param name="deviceType"></param>
	/// <returns></returns>
	int GetPlayerCount(long placeId, DeviceType deviceType);

	/// <summary>
	/// Gets player count by universe.
	/// </summary>
	/// <note type="caution">
	/// This methods will take into account config settings' ExcludedMatchmakingContextIds.
	/// </note>
	/// <param name="universeId"></param>
	/// <returns></returns>
	int GetUniversePlayerCount(long universeId);

	/// <summary>
	/// Gets player count by universe Id, device type.
	/// </summary>
	/// <note type="caution">
	/// This methods will take into account config settings' ExcludedMatchmakingContextIds.
	/// </note>
	/// <param name="universeId"></param>
	/// <param name="deviceType"></param>
	/// <returns></returns>
	int GetUniversePlayerCount(long universeId, DeviceType deviceType);

	/// <summary>
	/// Gets a dictionary of player counts by universe Id, country Id and mapped platform Id.
	/// </summary>
	/// <param name="universeId"></param>
	/// <param name="hashValuePairPlatformMappings"></param>
	/// <returns></returns>
	Dictionary<int, Dictionary<int, int>> GetUniversePlayerCountByCountryIdAndMappedPlatformId(long universeId, HashValuePair<Dictionary<int, int>> hashValuePairPlatformMappings);

	/// <summary>
	/// Gets universe summary by universe Id.
	/// </summary>
	/// <note type="caution">
	/// This methods will take into account config settings' ExcludedMatchmakingContextIds.
	/// </note>
	/// <param name="universeId"></param>
	/// <returns></returns>
	IUniverseSummary GetUniverseSummary(long universeId);
}
