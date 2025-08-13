using System;

namespace Roblox.Games.Client;

public class RankedServer
{
	public string Ip { get; set; }

	public DateTime Updated { get; set; }

	public int DatacenterId { get; set; }

	public int PolicyGroupId { get; set; }

	public bool IsInBleedoff { get; set; }

	public bool IsHealthy { get; set; }

	public int PerformanceUnits { get; set; }

	public int PerformanceUnitsRaw { get; set; }

	public double AvailableCpu { get; set; }

	public double AvailableBandwidth { get; set; }

	public double RelevantAvailableBandwidth { get; set; }

	public double RelevantAvailablePhysicalMemoryGigabytes { get; set; }

	public double CpuUsage { get; set; }

	public int RccServiceProcesses { get; set; }

	public int ProcessorCount { get; set; }

	public double TotalPhysicalMemoryGigabytes { get; set; }

	public double AvailablePhysicalMemoryGigabytes { get; set; }

	public string GamesRelayVersion { get; set; }

	public int LogicalProcessorCount { get; set; }

	public double UploadSpeedKilobytesPerSecond { get; set; }

	public double DownloadSpeedKilobytesPerSecond { get; set; }

	public string RccVersion { get; set; }

	public string ApplicationName { get; set; }

	public string NetworkBandwidthByNic { get; set; }

	public DateTime? LastSuccessfulRccApplicationSettingsFetchTime { get; set; }

	public string KernelVersion { get; set; }

	public int ReadyRccServiceProcesses { get; set; }

	public int? ReadyProcessCount { get; set; }

	public double Penalty { get; set; }

	public MatchmakingCapability MatchmakingCapability { get; set; }

	public GameStartCapability GameStartCapability { get; set; }

	public int WorstPosition { get; set; }

	public double Score { get; set; }
}
