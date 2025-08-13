using System.Collections.Generic;
using Roblox.GameInstances.Client;

namespace Roblox.Platform.GameInstances;

internal class UniverseSummary : IUniverseSummary
{
	public long Id { get; set; }

	public int GameCount { get; set; }

	public int PlayerCount { get; set; }

	public int Under13PlayerCount { get; set; }

	public IDictionary<int, int> PlayerCountByPlatformId { get; set; }

	public IDictionary<int, int> Under13PlayerCountByPlatformId { get; set; }

	public IDictionary<int, int> VrPlayerCountByPlatformId { get; set; }

	public int VrPlayerCount { get; set; }

	/// <summary>
	/// Keys are bot check status strings or their combinations separated by comas,
	/// values are player counts.
	/// </summary>
	public IDictionary<string, int> PlayerCountByBotCheckStatus { get; set; }

	public UniverseSummary()
	{
	}

	public UniverseSummary(Roblox.GameInstances.Client.UniverseSummary universeSummary)
	{
		Id = universeSummary.UniverseId;
		GameCount = universeSummary.GameCount;
		PlayerCount = universeSummary.PlayerCount;
		Under13PlayerCount = universeSummary.Under13PlayerCount;
		PlayerCountByPlatformId = universeSummary.PlayerCountByPlatformId;
		Under13PlayerCountByPlatformId = universeSummary.Under13PlayerCountByPlatformId;
		VrPlayerCountByPlatformId = universeSummary.VrPlayerCountByPlatformId;
		VrPlayerCount = universeSummary.VrPlayerCount;
		PlayerCountByBotCheckStatus = universeSummary.PlayerCountByBotCheckStatus;
	}
}
