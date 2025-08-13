using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Instrumentation;
using Roblox.Web.RequestValidator;

namespace Roblox.Web;

[ExcludeFromCodeCoverage]
internal class GameServerRequestValidationPerformanceCounter : IGameServerRequestValidationPerformanceCounters
{
	private readonly IDictionary<GameServerRequestValidationMetricsCounter, IRateOfCountsPerSecondCounter> _PerformanceCounters = new Dictionary<GameServerRequestValidationMetricsCounter, IRateOfCountsPerSecondCounter>();

	private const string _PerformanceCategory = "Roblox.GameServerRequestValidationV2";

	public GameServerRequestValidationPerformanceCounter(ICounterRegistry counterRegistry)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_PerformanceCounters.Add(GameServerRequestValidationMetricsCounter.ValidRequest, counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GameServerRequestValidationV2", "ValidRequest"));
		_PerformanceCounters.Add(GameServerRequestValidationMetricsCounter.AlternateAccessKeyUsed, counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GameServerRequestValidationV2", "AlternateAccessKeyUsed"));
		_PerformanceCounters.Add(GameServerRequestValidationMetricsCounter.InvalidIpAddress, counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GameServerRequestValidationV2", "InvalidIpAddress"));
		_PerformanceCounters.Add(GameServerRequestValidationMetricsCounter.InvalidAccessKey, counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GameServerRequestValidationV2", "InvalidAccessKey"));
		_PerformanceCounters.Add(GameServerRequestValidationMetricsCounter.MissingAccessKey, counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GameServerRequestValidationV2", "MissingAccessKey"));
		_PerformanceCounters.Add(GameServerRequestValidationMetricsCounter.InvalidPlaceId, counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GameServerRequestValidationV2", "InvalidPlaceId"));
		_PerformanceCounters.Add(GameServerRequestValidationMetricsCounter.InvalidGameId, counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GameServerRequestValidationV2", "InvalidGameId"));
		_PerformanceCounters.Add(GameServerRequestValidationMetricsCounter.JobSignatureInvalid, counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GameServerRequestValidationV2", "JobSignatureInvalid"));
		_PerformanceCounters.Add(GameServerRequestValidationMetricsCounter.AlternateJobSignatureSaltUsed, counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GameServerRequestValidationV2", "AlternateJobSignatureSaltUsed"));
	}

	public void IncrementCounter(GameServerRequestValidationMetricsCounter counterType)
	{
		if (!_PerformanceCounters.ContainsKey(counterType))
		{
			throw new ArgumentException("counterType");
		}
		_PerformanceCounters[counterType].Increment();
	}
}
