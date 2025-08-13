using System.Collections.Generic;
using Roblox.Platform.Games.Interfaces;

namespace Roblox.Platform.Games;

public interface IMatchmakingContextFactory
{
	IMatchmakingContext GetXboxLiveMatchmakingContext();

	IMatchmakingContext GetDefaultMatchmakingContext();

	IMatchmakingContext GetCloudEditMatchmakingContext();

	IMatchmakingContext GetCloudEditPlayTestMatchmakingContext();

	Dictionary<string, IMatchmakingContext> GetMatchmakingContexts();

	int[] GetGameShutdownExcludedMatchmakingContextIds();

	IMatchmakingContext GetMatchmakingContext(string name);
}
