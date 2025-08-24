using System.Collections.Generic;

namespace Roblox.Platform.GameInstances;

public interface IUniverseSummary
{
	long Id { get; }

	int GameCount { get; }

	int PlayerCount { get; }

	int Under13PlayerCount { get; }

	IDictionary<int, int> PlayerCountByPlatformId { get; }

	IDictionary<int, int> Under13PlayerCountByPlatformId { get; }

	IDictionary<int, int> VrPlayerCountByPlatformId { get; }

	int VrPlayerCount { get; }
}
