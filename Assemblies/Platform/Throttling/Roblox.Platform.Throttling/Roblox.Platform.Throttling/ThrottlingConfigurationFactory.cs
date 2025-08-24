using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Paging;
using Roblox.Platform.Throttling.Entities;

namespace Roblox.Platform.Throttling;

public static class ThrottlingConfigurationFactory
{
	private const int _PageSize = 50;

	public static IRateLimit CreateThrottleRequestRateLimit(string nameSpace, string actionType, int totalRequest, TimeSpan interval, RequestType requestType)
	{
		if (string.IsNullOrWhiteSpace(nameSpace) || string.IsNullOrWhiteSpace(actionType))
		{
			return null;
		}
		Roblox.Platform.Throttling.Entities.Namespace orCreate = Roblox.Platform.Throttling.Entities.Namespace.GetOrCreate(nameSpace);
		Roblox.Platform.Throttling.Entities.ActionType actionTypeEntity = Roblox.Platform.Throttling.Entities.ActionType.GetOrCreate(actionType + "_" + requestType);
		return Roblox.Platform.Throttling.Entities.RateLimit.CreateNew(intervalInTicks: interval.Ticks, namespaceId: orCreate.ID, actionTypeId: actionTypeEntity.ID, numberOfRequest: totalRequest).Translate();
	}

	public static IGameServerRateLimit CreateGameServerRequestRateLimit(string nameSpace, string actionType, int baseRequest, int perPlayerBaseLimit, TimeSpan interval)
	{
		if (string.IsNullOrWhiteSpace(nameSpace) || string.IsNullOrWhiteSpace(actionType))
		{
			return null;
		}
		Roblox.Platform.Throttling.Entities.Namespace orCreate = Roblox.Platform.Throttling.Entities.Namespace.GetOrCreate(nameSpace);
		Roblox.Platform.Throttling.Entities.ActionType baseActionTypeEntity = Roblox.Platform.Throttling.Entities.ActionType.GetOrCreate(actionType + "_Base");
		Roblox.Platform.Throttling.Entities.ActionType perPlayerActionTypeEntity = Roblox.Platform.Throttling.Entities.ActionType.GetOrCreate(actionType + "_PerPlayer");
		long intervalInTicks = interval.Ticks;
		Roblox.Platform.Throttling.Entities.RateLimit baseRateLimitEntity = Roblox.Platform.Throttling.Entities.RateLimit.CreateNew(orCreate.ID, baseActionTypeEntity.ID, baseRequest, intervalInTicks);
		Roblox.Platform.Throttling.Entities.RateLimit perPlayerRateLimitEntity = Roblox.Platform.Throttling.Entities.RateLimit.CreateNew(orCreate.ID, perPlayerActionTypeEntity.ID, perPlayerBaseLimit, intervalInTicks);
		return new GameServerRateLimit(baseRateLimitEntity.Translate(), perPlayerRateLimitEntity.Translate());
	}

	public static IActionType GetActionTypeById(long id)
	{
		return Roblox.Platform.Throttling.Entities.ActionType.Get(id).Translate();
	}

	public static INamespace GetNamespaceById(long id)
	{
		return Roblox.Platform.Throttling.Entities.Namespace.Get(id).Translate();
	}

	public static IPagedResult<long, int, IRateLimit> GetRateLimitsPaged(long offset, int count)
	{
		long total = Roblox.Platform.Throttling.Entities.RateLimit.GetTotalNumberOfRateLimits();
		IEnumerable<RateLimit> rateLimits = Roblox.Platform.Throttling.Entities.RateLimit.GetRateLimitsPaged(offset, 50L).Select(Extensions.Translate);
		return new PagedResult<long, int, IRateLimit>
		{
			Count = total,
			PageItems = rateLimits
		};
	}

	public static IRateLimit UpdateRateLimit(long rateLimitId, int numberOfRequest, TimeSpan timeInterval)
	{
		Roblox.Platform.Throttling.Entities.RateLimit obj = Roblox.Platform.Throttling.Entities.RateLimit.Get(rateLimitId) ?? throw new InvalidRateLimitException(rateLimitId);
		obj.IntervalInTicks = timeInterval.Ticks;
		obj.NumberOfRequests = numberOfRequest;
		obj.Save();
		return obj.Translate();
	}

	public static IRateLimit GetRateLimitById(long rateLimitId)
	{
		return Roblox.Platform.Throttling.Entities.RateLimit.Get(rateLimitId).Translate();
	}

	public static void DeleteRateLimit(IRateLimit rateLimit)
	{
		if (rateLimit != null)
		{
			Roblox.Platform.Throttling.Entities.RateLimit.Get(rateLimit.Id)?.Delete();
		}
	}
}
