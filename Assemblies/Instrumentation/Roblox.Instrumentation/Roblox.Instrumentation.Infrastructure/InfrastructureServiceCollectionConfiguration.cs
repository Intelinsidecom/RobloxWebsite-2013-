using System.Collections.Generic;

namespace Roblox.Instrumentation.Infrastructure;

internal class InfrastructureServiceCollectionConfiguration : ICollectionConfiguration
{
	private readonly IReadOnlyCollection<string> _InfluxEndpoints;

	private readonly bool _IsShardingEnabled;

	private readonly InfluxOutputSharder _InfluxOutputSharder;

	public string HostIdentifier { get; }

	public string FarmIdentifier { get; }

	public string SuperFarmIdentifier { get; }

	public string InfluxDatabaseName { get; }

	public InfluxCredentials InfluxCredentials { get; }

	public InfrastructureServiceCollectionConfiguration(string hostIdentifier, string farmIdentifier, string superFarmIdentifier, string influxDatabaseName, IReadOnlyCollection<string> influxEndpoints, InfluxCredentials influxCredentials, bool isShardingEnabled)
	{
		_InfluxEndpoints = influxEndpoints;
		_IsShardingEnabled = isShardingEnabled;
		HostIdentifier = hostIdentifier;
		FarmIdentifier = farmIdentifier;
		SuperFarmIdentifier = superFarmIdentifier;
		InfluxDatabaseName = influxDatabaseName;
		InfluxCredentials = influxCredentials;
		if (_IsShardingEnabled)
		{
			_InfluxOutputSharder = new InfluxOutputSharder(influxEndpoints);
		}
	}

	public IReadOnlyCollection<string> GetInfluxEndpointsForCategory(string category)
	{
		if (_IsShardingEnabled)
		{
			return (IReadOnlyCollection<string>)(object)new string[1] { _InfluxOutputSharder.GetInfluxUrl(category) };
		}
		return _InfluxEndpoints;
	}
}
