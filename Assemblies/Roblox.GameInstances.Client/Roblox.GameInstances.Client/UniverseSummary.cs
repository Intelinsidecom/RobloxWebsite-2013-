using System.Collections.Generic;
using Roblox.GameInstances.Interfaces;

namespace Roblox.GameInstances.Client;

public class UniverseSummary : IUniverseSummary
{
	public static readonly UniverseSummary Empty = new UniverseSummary();

	public long Id { get; set; }

	public long UniverseId { get; set; }

	public int GameCount { get; set; }

	public int PlayerCount { get; set; }

	public int Under13PlayerCount { get; set; }

	public IDictionary<int, int> PlayerCountByPlatformId { get; set; }

	public IDictionary<int, int> Under13PlayerCountByPlatformId { get; set; }

	public IDictionary<int, int> VrPlayerCountByPlatformId { get; set; }

	public bool IsFound { get; set; }

	public int VrPlayerCount { get; set; }

	public IDictionary<string, int> PlayerCountByBotCheckStatus { get; set; }
}
