using System.Collections.Generic;

namespace Roblox.Instrumentation;

public interface ICollectionConfiguration
{
	string FarmIdentifier { get; }

	string SuperFarmIdentifier { get; }

	string HostIdentifier { get; }

	string InfluxDatabaseName { get; }

	InfluxCredentials InfluxCredentials { get; }

	IReadOnlyCollection<string> GetInfluxEndpointsForCategory(string category);
}
