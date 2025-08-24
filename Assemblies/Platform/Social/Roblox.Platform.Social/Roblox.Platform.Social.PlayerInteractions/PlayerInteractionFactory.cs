using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Paging;

namespace Roblox.Platform.Social.PlayerInteractions;

public class PlayerInteractionFactory : IPlayerInteractionFactory
{
	private readonly IPlayerInteractionDataAccessor _DataAccessor;

	public PlayerInteractionFactory(IPlayerInteractionDataAccessor dataAccessor)
	{
		_DataAccessor = dataAccessor;
	}

	/// <summary>
	/// Gets a paged result of a user's recent player interactions
	/// </summary>
	/// <param name="userId">The userID of the user you care about</param>
	/// <param name="startIndex">0 based start index</param>
	/// <param name="maxRows">will be capped at the maximum stored</param>
	/// <returns></returns>
	public IPagedResult<long, IPlayerInteraction> GetRecentPlayerInteractions(long userId, int startIndex, int maxRows)
	{
		if (startIndex < 0)
		{
			throw new IndexOutOfRangeException("startIndex out of range (<0).");
		}
		if (userId <= 0)
		{
			return new PagedResult<long, IPlayerInteraction>();
		}
		maxRows = Math.Min(maxRows, _DataAccessor.MaxPlayerInteractionsToStore);
		IEnumerable<PlayerInteraction> playerInteractions = _DataAccessor.GetRecentPlayerInteractions(userId, startIndex, maxRows);
		int totalCount = _DataAccessor.GetTotalRecentPlayerInteractionCount(userId);
		_DataAccessor.RefreshKeyExpiry(userId);
		return new PagedResult<long, IPlayerInteraction>
		{
			PageItems = playerInteractions,
			Count = totalCount
		};
	}

	/// <summary>
	/// Records player interactions between the user specified and the list of other users.
	/// Also records player interactions in the reverse direction
	/// </summary>
	/// <param name="userId">The user who joined the server</param>
	/// <param name="otherUserIds">The other users in the server</param>
	/// <param name="placeId">The place ID of the place the server is running.</param>
	/// <param name="interactionTime">The time at which this interaction ocurred</param>
	public void UpdateRecentPlayerInteractions(long userId, IReadOnlyCollection<long> otherUserIds, long placeId, DateTime interactionTime)
	{
		if (otherUserIds == null)
		{
			return;
		}
		List<long> validOtherUserIds = otherUserIds.Where((long id) => id > 0 && id != userId).ToList();
		if (userId <= 0 || validOtherUserIds.Count == 0 || placeId <= 0)
		{
			return;
		}
		_DataAccessor.UpdateRecentPlayerInteractions(userId, validOtherUserIds, placeId, interactionTime);
		_DataAccessor.RefreshKeyExpiry(userId);
		foreach (long otherUserId in validOtherUserIds)
		{
			_DataAccessor.UpdateRecentPlayerInteractions(otherUserId, new List<long> { userId }, placeId, interactionTime);
			_DataAccessor.RefreshKeyExpiry(otherUserId);
		}
	}

	internal void DeleteAllPlayerInteractions(long userId)
	{
		_DataAccessor.DeleteAllPlayerInteractions(userId);
	}
}
