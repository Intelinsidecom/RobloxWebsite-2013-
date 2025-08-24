using System;
using Roblox.Platform.Throttling.Entities;
using Roblox.Platform.Throttling.Properties;

namespace Roblox.Platform.Throttling;

internal class GameServerRequest : IRequest
{
	private const string _ActionSuffixBase = "_Base";

	private const string _ActionSuffixPerPlayer = "_PerPlayer";

	private readonly string _Key;

	private readonly string _Namespace;

	private readonly string _ActionType;

	public int CurrentNumberOfPlayers { get; private set; }

	public bool IsEnabled()
	{
		return true;
	}

	public GameServerRequest(string gameInstanceId, int currentNumerOfPlayers, string nameSpace, string actionType)
	{
		CurrentNumberOfPlayers = currentNumerOfPlayers;
		_Namespace = nameSpace;
		_ActionType = actionType;
		_Key = _Namespace + "_" + _ActionType + "_" + gameInstanceId;
	}

	private GameServerRateLimit GetGameServerRateLimit()
	{
		Roblox.Platform.Throttling.Entities.Namespace namespaceEntity = Roblox.Platform.Throttling.Entities.Namespace.GetOrCreate(_Namespace);
		Roblox.Platform.Throttling.Entities.ActionType baseActionTypeEntity = Roblox.Platform.Throttling.Entities.ActionType.GetOrCreate(_ActionType + "_Base");
		Roblox.Platform.Throttling.Entities.ActionType perPlayerActionTypeEntity = Roblox.Platform.Throttling.Entities.ActionType.GetOrCreate(_ActionType + "_PerPlayer");
		if (baseActionTypeEntity == null || perPlayerActionTypeEntity == null || namespaceEntity == null)
		{
			return null;
		}
		Roblox.Platform.Throttling.Entities.RateLimit baseRateLimit = Roblox.Platform.Throttling.Entities.RateLimit.GetByNamespaceIDActionTypeID(namespaceEntity.ID, baseActionTypeEntity.ID);
		Roblox.Platform.Throttling.Entities.RateLimit perPlayerRateLimit = Roblox.Platform.Throttling.Entities.RateLimit.GetByNamespaceIDActionTypeID(namespaceEntity.ID, perPlayerActionTypeEntity.ID);
		if (baseRateLimit == null || perPlayerRateLimit == null)
		{
			return null;
		}
		return new GameServerRateLimit(baseRateLimit.Translate(), perPlayerRateLimit.Translate());
	}

	public string GetKey()
	{
		return _Key;
	}

	public TimeSpan GetExpirationInterval()
	{
		return GetGameServerRateLimit()?.BaseRateLimit.Interval ?? Settings.Default.DefaultRequestDuration;
	}

	public long GetBudget()
	{
		GameServerRateLimit gameServerRateLimit = GetGameServerRateLimit();
		if (gameServerRateLimit == null)
		{
			return Settings.Default.DefaultRequestAmount;
		}
		IRateLimit baseRateLimit = gameServerRateLimit.BaseRateLimit;
		IRateLimit perPlayerRateLimit = gameServerRateLimit.PerPlayerRateLimit;
		return baseRateLimit.NumberOfRequests + perPlayerRateLimit.NumberOfRequests * CurrentNumberOfPlayers;
	}
}
