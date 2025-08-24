using System.Collections.Generic;
using Roblox.Paging;

namespace Roblox.Platform.Games;

public class GamePagedResult : KeyedPagedResult<IGameWithUniverseAndRootPlace, long>, IGamePagedResult, IKeyedPagedResult<IGameWithUniverseAndRootPlace, long>
{
	public GamePagedResult(IReadOnlyCollection<IGameWithUniverseAndRootPlace> pageItems, PageKeyInfo<long> nextPageKey)
		: base(pageItems, nextPageKey)
	{
	}
}
