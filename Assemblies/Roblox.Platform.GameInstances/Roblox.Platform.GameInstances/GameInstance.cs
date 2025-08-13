using System;
using System.Collections.Generic;
using Roblox.GameInstances.Client;

namespace Roblox.Platform.GameInstances;

internal class GameInstance : IGameInstance
{
	public Guid Id { get; set; }

	public long PlaceId { get; set; }

	public double Fps { get; set; }

	public int Ping { get; set; }

	public ICollection<long> PlayerIds { get; set; }

	public byte Capacity { get; set; }

	public string ServerIpAddress { get; set; }

	public Guid? GameCode { get; set; }

	public int MatchmakingContextId { get; set; }

	public GameInstance()
	{
	}

	internal GameInstance(Game clientRunningGame)
	{
		Id = clientRunningGame.Id;
		PlaceId = clientRunningGame.PlaceId;
		Fps = clientRunningGame.Fps;
		Ping = clientRunningGame.Ping;
		PlayerIds = clientRunningGame.PlayerIds;
		Capacity = clientRunningGame.Capacity;
		ServerIpAddress = clientRunningGame.ServerIpAddress;
		GameCode = clientRunningGame.GameCode;
		MatchmakingContextId = clientRunningGame.MatchmakingContextId;
	}
}
