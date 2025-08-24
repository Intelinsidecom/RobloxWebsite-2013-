using System.Collections.Generic;
using Roblox.GameInstances.Client;

namespace Roblox.Platform.GameInstances;

internal class PlaceSummary : IPlaceSummary
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

	public PlaceSummary()
	{
	}

	public PlaceSummary(Roblox.GameInstances.Client.PlaceSummary placeSummary)
	{
		Id = placeSummary.Id;
		GameCount = placeSummary.GameCount;
		PlayerCount = placeSummary.PlayerCount;
		Under13PlayerCount = placeSummary.Under13PlayerCount;
		PlayerCountByPlatformId = placeSummary.PlayerCountByPlatformId;
		Under13PlayerCountByPlatformId = placeSummary.Under13PlayerCountByPlatformId;
		VrPlayerCountByPlatformId = placeSummary.VrPlayerCountByPlatformId;
		VrPlayerCount = placeSummary.VrPlayerCount;
		PlayerCountByBotCheckStatus = placeSummary.PlayerCountByBotCheckStatus;
	}
}
