using System.Collections.Generic;
using Roblox.Platform.Games.Entities;
using Roblox.Platform.Games.Interfaces;
using Roblox.Platform.Games.Properties;

namespace Roblox.Platform.Games.Factories;

public class MatchmakingContextFactory : IMatchmakingContextFactory
{
	private const string DefaultName = "Default";

	private const string XBoxLiveName = "XBoxLive";

	private const string CloudEditName = "CloudEdit";

	private const string CloudEditPlayTestName = "CloudEditPlayTest";

	private readonly IMatchmakingContext _Default;

	private readonly IMatchmakingContext _XboxLive;

	private readonly IMatchmakingContext _CloudEdit;

	private readonly IMatchmakingContext _CloudEditPlayTest;

	private readonly Dictionary<string, IMatchmakingContext> _MatchmakingContexts;

	private readonly int[] _GameShutdownExcludedMatchmakingContextIds;

	public MatchmakingContextFactory()
	{
		_Default = GetMatchmakingContext("Default");
		_XboxLive = GetMatchmakingContext("XBoxLive");
		_CloudEdit = GetMatchmakingContext("CloudEdit");
		_CloudEditPlayTest = GetMatchmakingContext("CloudEditPlayTest");
		_GameShutdownExcludedMatchmakingContextIds = new int[2] { _CloudEdit.Id, _CloudEditPlayTest.Id };
		_MatchmakingContexts = new Dictionary<string, IMatchmakingContext>
		{
			{ _Default.Name, _Default },
			{ _XboxLive.Name, _XboxLive },
			{ _CloudEdit.Name, _CloudEdit },
			{ _CloudEditPlayTest.Name, _CloudEditPlayTest }
		};
	}

	public IMatchmakingContext GetXboxLiveMatchmakingContext()
	{
		return _XboxLive;
	}

	public IMatchmakingContext GetDefaultMatchmakingContext()
	{
		return _Default;
	}

	public IMatchmakingContext GetCloudEditMatchmakingContext()
	{
		return _CloudEdit;
	}

	public IMatchmakingContext GetCloudEditPlayTestMatchmakingContext()
	{
		return _CloudEditPlayTest;
	}

	public Dictionary<string, IMatchmakingContext> GetMatchmakingContexts()
	{
		return _MatchmakingContexts;
	}

	public int[] GetGameShutdownExcludedMatchmakingContextIds()
	{
		if (Settings.Default.ExcludeMatchmakingContextsFromGameShutdownEnabled)
		{
			return _GameShutdownExcludedMatchmakingContextIds;
		}
		return null;
	}

	public IMatchmakingContext GetMatchmakingContext(string name)
	{
		Roblox.Platform.Games.Entities.MatchmakingContext matchmakingContextEntity = Roblox.Platform.Games.Entities.MatchmakingContext.GetByValue(name);
		if (matchmakingContextEntity == null)
		{
			return null;
		}
		return new Roblox.Platform.Games.Interfaces.MatchmakingContext(matchmakingContextEntity.ID, matchmakingContextEntity.Value);
	}
}
